/*
 *  Copyright (C) 2013 Pavel Charvat
 * 
 *  This file is part of IEDExplorer.
 *
 *  IEDExplorer is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  IEDExplorer is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with IEDExplorer.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEDExplorer
{
    public class NodeIed : NodeBase
    {
        public NodeIed(string Name, Iec61850Model _model)
            : base(Name)
        {
            model = _model;
        }
        
        Iec61850Model model;

        public string VendorName { get; set; }

        public string ModelName { get; set; }

        public string Revision { get; set; }

        public bool DefineNVL { get; set; }

        public bool Identify { get; set; }

        public NodeBase FindNodeByAddress(string Domain, string IecAddress, bool FindList = false)
        {
            if (Domain == null || IecAddress == null)
                return null;
            NodeBase b = this.FindChildNode(Domain);
            if (b != null)
            {
                if (FindList)
                {
                    if ((b = b.FindChildNode(IecAddress)) == null)
                    {
                        return null;
                    }
                }
                else
                {
                    if (Name == "urcbs" || Name == "brcbs")
                    {
                        if ((b = b.FindChildNode(IecAddress)) == null)
                        {
                            return null;
                        }
                    }
                    else if (b is NodeFile && IecAddress == "")
                    {
                        return b;
                    }
                    else
                    {
                        string[] parts = IecAddress.Split(new char[] { '$', '.' });
                        for (int i = 0; i < parts.Length; i++)
                        {
                            if ((b = b.FindChildNode(parts[i])) == null)
                            {
                                return null;
                            }
                        }
                    }
                }
                return b;
            }
            return null;
        }

        public NodeBase FindNodeByAddress(string CompleteIecAddress, bool FindList = false)
        {
            if (CompleteIecAddress == null)
                return null;
            string[] parts = CompleteIecAddress.Split(new char[] { '/' }, 2);
            if (parts.Length == 2)
                return FindNodeByAddress(parts[0], parts[1], FindList);
            return null;
        }

        public NodeBase FindNodeByAddressWithDots(string domain, string iecAddress, bool findList = false)
        {
            if (domain == null || iecAddress == null)
                return null;
            NodeBase b = this.FindChildNode(domain);
            if (b != null)
            {
                if (findList)
                {
                    if ((b = b.FindChildNode(iecAddress)) == null)
                    {
                        return null;
                    }
                }
                else
                {
                    if (Name == "urcbs" || Name == "brcbs")
                    {
                        if ((b = b.FindChildNode(iecAddress)) == null)
                        {
                            return null;
                        }
                    }
                    else if (b is NodeFile && iecAddress == "")
                    {
                        return b;
                    }
                    else
                    {
                        string[] parts = iecAddress.Split(new char[] { '.' });
                        for (int i = 0; i < parts.Length; i++)
                        {
                            if ((b = b.FindChildNode(parts[i])) == null)
                            {
                                return null;
                            }
                        }
                    }
                }
                return b;
            }
            return null;
        }

        public NodeBase FindNodeByAddressWithDots(string completeIecAddress, bool findList = false)
        {
            if (completeIecAddress == null)
            {
                return null;
            }
            string[] parts = completeIecAddress.Split(new char[] { '/' }, 2);
            if (parts.Length == 2)
            {
                return FindNodeByAddressWithDots(parts[0], parts[1], findList);
            }
            return null;
        }

        //public NodeBase FindRCBNodeByAddress(string domain, string iecAdress, bool isListFound = false)
        //{

        //}

        //public NodeBase FindRCBNodeByAddress(string completeIecAddress, bool isListFound = false)
        //{
        //    if (completeIecAddress == null)
        //    {
        //        return null;
        //    }
        //    string[] parts = completeIecAddress.Split(new char[] { '/' }, 2);
        //    if (parts.Length == 2)
        //    {
        //        return null;
        //    }
        //    return null;
        //}

        public Iec61850State iecs { get; set; }

        public override void SaveModel(List<String> lines, bool fromSCL)
        {
            // Syntax: MODEL(<model name>){…}
            lines.Add("MODEL(" + IedModelName + "){");
            foreach (NodeBase b in _childNodes)
            {
                b.SaveModel(lines, fromSCL);
            }
            lines.Add("}");
        }

        public string IedModelName { get; set; }

        public Iec61850Model Model { get { return model; } }

        public bool isIecTree() { return model.iec == this; }

    }
}
