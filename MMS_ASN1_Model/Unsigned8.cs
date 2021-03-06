
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace MMS_ASN1_Model {


    [ASN1PreparedElement]
    [ASN1BoxedType ( Name = "Unsigned8" )]
    public class Unsigned8: IASN1PreparedElement {
    
            private int val;
            
            [ASN1Integer( Name = "Unsigned8" )]
            [ASN1ValueRangeConstraint ( 
		
		Min = 0L, 
		
		Max = 127L 
		
		) ]
	    
            public int Value
            {
                get { return val; }
                set { val = value; }
            }
            
            public Unsigned8() {
            }

            public Unsigned8(int value) {
                this.Value = value;
            }            

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Unsigned8));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
