using FactoryMethod.Subscriptions;

namespace FactoryMethod.Creators
{
    public abstract class CreateSubscription
    {
        public abstract ISubscription BuySubcription(string nameofsub);
        protected static ISubscription ReturnSubscription(string nameofsub)
        {
            switch (nameofsub)
            {
                case "Domestic":
                    return new DomesticSubscription();
                case "Education":
                    return new EducationalSubscription();
                case "Premium":
                    return new PremiumSubscription();
                default:
                    throw new NotImplementedException("We don't have this type of subscription");
            }
        }

    }
}
