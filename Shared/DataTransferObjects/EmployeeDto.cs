using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DataTransferObjects
{
    public record EmployeeDto(Guid Id, string Name, int Age, string Position);

}
