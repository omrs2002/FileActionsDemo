using FileActionsDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FileActionsDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FileActionsDemoController : AbpControllerBase
{
    protected FileActionsDemoController()
    {
        LocalizationResource = typeof(FileActionsDemoResource);
    }
}
