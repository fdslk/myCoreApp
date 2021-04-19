using AutoMapper;

public class AutoMapperDemos{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<OrignalItemModels, ConvertItemModel>().ForMember(dest=>dest.Id, opt=>opt.MapFrom(src=>src.Id));
            // Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)

        }
    }
}