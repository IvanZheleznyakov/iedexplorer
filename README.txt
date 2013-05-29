========================  LICENSES ========================
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

IEDExplorer uses Binary Notes ASN.1 software library:

/*
* Copyright 2006 Abdulla G. Abdurakhmanov (abdulla.abdurakhmanov@gmail.com).
* 
* Licensed under the LGPL, Version 2 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
* 
*      http://www.gnu.org/copyleft/lgpl.html
* 
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
* 
* With any your questions welcome to my e-mail 
* or blog at http://abdulla-a.blogspot.com.
*/


========================  IEDExplorer ========================


The IEDExplorer project has been created in my free time in order to reach some familiarization
and self-education in the IEC61850 protocol.
The result is the only (as I have seen over Internet) pure .net managed MMS stack (not quite complete!)
and a very basic IEC61850 MMS client implementation.

The code is NOT in production quality, written by a non-professional programmer:
- it completely lacks tests
- it uses Binary Notes implementation of MMS ASN.1 encoding/decoding, which is relatively
  slow in the C# flavour, thus not really suitable for a serious usage
- it has a simplistic UI and UI bindings (desperately needs refactoring)
- IEC61850 is not suitably modelled, and model is very incomplete (refactoring needed)
- the MMS client side only has been implemented

On the other side:
- it works (at least for me on some test setups)
- it has already helped me in some situations in debugging 61850 communications
- it has a big potential for improvement
- it can be a free alternative to some commercial test utilities
- it runs under Windows and under Linux/Mono

The project is looking for enthusiastic programmers who want to explore the mysterious
world of IEC61850 protocol.

Rev 0.1 2013/05/29
The first release 0.1 is an "as is" copy of the last development.
