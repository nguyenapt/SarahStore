using System;
using System.Threading.Tasks;
using Sarah.TrainingHub.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Sarah.TrainingHub;

public class StoreDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Subject, Guid> _subjectRepository;

    public StoreDataSeederContributor(IRepository<Subject, Guid> bookRepository)
    {
        _subjectRepository = bookRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        //if (await _bookRepository.GetCountAsync() <= 0)
        //{
        //    await _bookRepository.InsertAsync(
        //        new Subject
        //        {
        //            Name = "1984",
        //            Type = BookType.Dystopia,
        //            PublishDate = new DateTime(1949, 6, 8),
        //            Price = 19.84f
        //        },
        //        autoSave: true
        //    );

        //    await _bookRepository.InsertAsync(
        //        new Book
        //        {
        //            Name = "The Hitchhiker's Guide to the Galaxy",
        //            Type = BookType.ScienceFiction,
        //            PublishDate = new DateTime(1995, 9, 27),
        //            Price = 42.0f
        //        },
        //        autoSave: true
        //    );
        //}
    }
}