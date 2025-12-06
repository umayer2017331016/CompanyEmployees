using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DataTransferObjects
{
    public record EmployeeForUpdateDto(string Name, int Age, string Position);
}
