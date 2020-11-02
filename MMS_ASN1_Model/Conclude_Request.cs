using org.bn;
using org.bn.attributes;
using org.bn.coders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS_ASN1_Model
{
    [ASN1PreparedElement]
    [ASN1Null(Name = "Conclude-Request")]
    public class Conclude_Request : IASN1PreparedElement
    {

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Conclude_Request));
        public IASN1PreparedElementData PreparedData => throw new NotImplementedException();

        public void initWithDefaults()
        {

        }
    }
}
