using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedInUICloneXF.Model
{
    class PostItem
    {
        public string PersonName { get; set; }
        public string PersonProfilePicture { get; set; }
        public string PersonCurrentPosition { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int PostLikes { get; set; }
        public int PostComments { get; set; }

    }
}
