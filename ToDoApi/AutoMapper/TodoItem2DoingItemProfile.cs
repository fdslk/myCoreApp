using ToDoApi.Models;
using AutoMapper;

namespace ToDoApi.AutoMapper{
    public class OrganizationProfile : Profile
{
	public OrganizationProfile()
	{
		CreateMap<TodoItem, DoingItem>().ReverseMap();
		// Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
	}
}
}