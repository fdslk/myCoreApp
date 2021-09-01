namespace AbstractFactoryDesignPatternInCSharp  
{
    interface IMobilePhone
    {
        INormalPhone GetNormalPhone ();
        ISmartPhone GetSmartPhone();
    }

    internal interface ISmartPhone
    {
        string GetModelDetails();
    }

    internal interface INormalPhone
    {
        string GetModelDetails();
    }
    
    class Nokia: IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new NormalNokia();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SmartNokia();
        }
    }

    class NormalNokia : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Nokia normal phone.";
        }
    }

    class SmartNokia: ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Nokia smart phone.";
        }
    }

    class Samsung : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new NormalSamsung();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SmartSamsung();
        }
    }
    
    class NormalSamsung : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Samsung normal phone.";
        }
    }

    class SmartSamsung: ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Samsung smart phone.";
        }
    }

    class MobileFactory
    {
        private INormalPhone _normalPhone;
        private ISmartPhone _smartPhone;

        public MobileFactory(IMobilePhone factory)
        {
            _smartPhone = factory.GetSmartPhone();
            _normalPhone = factory.GetNormalPhone();
        }

        public string GetNormalPhoneDetail()
        {
            return _normalPhone.GetModelDetails();
        }
        
        public string GetSamrtPhoneDetail()
        {
            return _smartPhone.GetModelDetails();
        }
    }
}  