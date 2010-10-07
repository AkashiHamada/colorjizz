﻿using System;
using System.Collections.Generic;

namespace ColorJizz
{
    public class Hex : AbstractColor
    {
        public uint hex;

        new protected ConversionMethod toSelf = ConversionMethod.toHex;

        public Hex(uint hex)
        {
            this.hex = hex;
        }

        public static Hex fromString(string str)
        {
            return null;
        }

        public override Hex toHex()
        {
            return this;
        }

        public override RGB toRGB()
        {
   			int r = Convert.ToInt32((hex & 0xFF0000) >> 16);
            int g = Convert.ToInt32((hex & 0x00FF00) >> 8);
            int b = Convert.ToInt32((hex & 0x0000FF));
			return new RGB(r,g,b);
        }

        public override XYZ toXYZ()
        {
            return this.toRGB().toXYZ();
        }

        public override HSV toHSV()
        {
            return this.toRGB().toHSV();
        }

        public override CMY toCMY()
        {
            return this.toRGB().toCMY();
        }

        public override CMYK toCMYK()
        {
            return this.toCMY().toCMYK();
        }

        public override CIELab toCIELab()
        {
            return this.toXYZ().toCIELab();
        }

        public override CIELCh toCIELCh()
        {
            return this.toCIELab().toCIELCh();
        }

        public override string ToString()
        {
            return this.hex.ToString("X").PadLeft(4, '0');
        }


    }
}
