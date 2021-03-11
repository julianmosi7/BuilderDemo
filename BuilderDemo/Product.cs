using System;

public class Product
  {
    private readonly string requiredA; //required
    private readonly string requiredB; //required
    private readonly int optionalC;    //optional
    private readonly string optionalD; //optional

    public string RequiredA => requiredA;
    public string RequiredB => requiredB;
    public int OptionalC => optionalC;
    public string OptionalD => optionalD;
    public override string ToString() => $"{requiredB} {requiredA} / {optionalC}, {optionalD}";

    private Product(Builder builder)
    {
        this.requiredA = builder.requiredA;
        this.requiredB = builder.requiredB;
        this.optionalC = builder.optionalC;
        this.optionalD = builder.optionalD;
    }
    
    public class Builder
    {
        internal readonly string requiredA; //required
        internal readonly string requiredB; //required
        internal int optionalC;    //optional
        internal string optionalD; //optional

        public Builder(string requiredA, string requiredB)
        {
            this.requiredA = requiredA;
            this.requiredB = requiredB;
        }

        public Builder OptionalC(int optionalC)
        {
            this.optionalC = optionalC;
            return this;
        }

        public Builder OptionalD(string optionalD)
        {
            this.optionalD = optionalD;
            return this;
        }

        public Product Build()
        {
            var product = new Product(this);
            //validate product...
            if (product.optionalC >  1000)
                throw new InvalidOperationException($"invalid number {product.OptionalC}");
            return product;
        }
    }

  }