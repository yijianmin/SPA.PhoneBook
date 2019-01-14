using Abp.Application.Services.Dto;

namespace SPACore.PhoneBook.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

