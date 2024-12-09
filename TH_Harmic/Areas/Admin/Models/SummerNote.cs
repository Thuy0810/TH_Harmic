namespace TH_Harmic.Areas.Admin.Models
{
    public class SummerNote
    {
        public SummerNote(string idEitor, bool loadLibrary=true) 
        {
           IDEitor = idEitor;
            LoadLibrary = loadLibrary;
        }
        public string IDEitor { get; set; }
        public bool LoadLibrary { get; set;}
        public int Height { get; set; }
        public string toolBar { get; set; } = @"
[
        ['style', ['style']],
        ['font',['bold', 'underline', 'clear']],
         ['color', ['color']],
        ['para',['ul', 'ol', 'paragraph']],
        ['table',['table']],
        ['insert',['link', 'elfinderFiles', 'video', 'elfinderFiles']],
        ['view',['fullscreen', 'codeview', 'help']]
]
        ";
        
    }
}
