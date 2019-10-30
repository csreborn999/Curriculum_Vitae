using System;
using System.Collections.Generic;
using System.Text;

namespace head_first_OOAD_Guitar
{
    class GuitarSpec
    {
        private Builder builder;
        private String model;
        private Type type;
        private int numStrings;
        private Wood backWood, topWood;
        public GuitarSpec(Builder builder, String model, Type type, int numStrings, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.numStrings = numStrings;
            this.backWood = backWood;
            this.topWood = topWood;
        }
        public Builder getBuilder()
        {
            return builder;
        }
        public String getModel()
        {
            return model;
        }
        public Type getType()
        {
            return type;
        }
        public int getNumStrings()
        {
            return numStrings;
        }
        public Wood getBackWood()
        {
            return backWood;
        }
        public Wood getTopWood()
        {
            return topWood;
        }
        public bool matches(GuitarSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            else if ((model != null) && (!model.Equals("")) && (!model.ToLower().Equals(otherSpec.model.ToLower())))
                return false;
            else if (type != otherSpec.type)
                return false;
            else if (numStrings != otherSpec.numStrings)
                return false;
            else if (backWood != otherSpec.backWood)
                return false;
            else if (topWood != otherSpec.topWood)
                return false;
            else return true;
        }
    }
}
