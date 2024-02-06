using Photography;
using Music.Works;
using Works = Music.Works;
using TheAgent = Music.Bussiness.Agent;
namespace Photography
{
    class Photo
    {
        public string Title;
    }
    class Album
    {
        public Photo[] photos = new Photo[10];
    }
}
namespace Music
{
    namespace Works
    {
        class Album
        {
            public string Artist;
            public string Title;
        }
    }
    namespace Bussiness
    {
        class Agent
        {
            public string Name;
            public double Commission;
        }
    }
}
class NamespaceTest
{ 
    static void Main()
    {
        //Photo photos = new Photo();
        Photo photos = new Photo();
        Photography.Album album = new  Photography.Album();
        Works.Album album1=new Works.Album();
        TheAgent bussiness = new TheAgent();

    }
}
