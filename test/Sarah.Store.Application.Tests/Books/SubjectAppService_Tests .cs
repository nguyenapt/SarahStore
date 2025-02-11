using System;
using System.Linq;
using System.Threading.Tasks;
using Sarah.Store.Enumaration;
using Sarah.Store.Services.Subjects;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Xunit;

namespace Sarah.Store.Books;

public abstract class SubjectAppService_Tests<TStartupModule> : StoreApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly ISubjectAppService _subjectAppService;

    protected SubjectAppService_Tests()
    {
        _subjectAppService = GetRequiredService<ISubjectAppService>();
    }

    [Fact]
    public async Task Should_Get_List_Of_Books()
    {
        //Act
        var result = await _subjectAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "1984");
    }

    [Fact]
    public async Task Should_Create_A_Valid_Book()
    {
        //Act
        var result = await _subjectAppService.CreateAsync(
            new CreateUpdateSubjectDto
            {
                Name = "New test Subject",
                Description = "",
                IsDeactive = false,
            }
        );

        //Assert
        result.Id.ShouldNotBe(Guid.Empty);
        result.Name.ShouldBe("New test book");
    }
    
    [Fact]
    public async Task Should_Not_Create_A_Book_Without_Name()
    {
        var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
        {
            await _subjectAppService.CreateAsync(
                new CreateUpdateSubjectDto
                {
                    Name = "",
                    Description = ""                    
                }
            );
        });

        exception.ValidationErrors
            .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
    }
}