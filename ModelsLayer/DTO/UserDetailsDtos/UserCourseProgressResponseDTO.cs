using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO.UserDetailsDtos
{
    public class UserCourseProgressResponseDTO
    {
        public int LessonId { get; set; }
        public DateTime WatchedDate { get; set; }
    }
}
