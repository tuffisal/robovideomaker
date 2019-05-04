using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoboVideoMaker
{
  public class VideoMakerRobot
  {
    private Content content;

    public VideoMakerRobot(Content content)
    {
      this.content = content;
    }
    public void Start()
    {      
      Console.WriteLine($"Assunto do vídeo: {JsonConvert.SerializeObject(content)}");
    }
  }

  public class Content
  {
    public string SearchTerm { get; set; }
    public string Prefix { get; set; }
  }
}
