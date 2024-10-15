// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusMake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200311A")]
  public class ReqVersusMake : WebAPI
  {
    [Token(Token = "0x600DDAF")]
    [Address(RVA = "0xA8EF50", Offset = "0xA8DD50", VA = "0x10A8EF50")]
    public ReqVersusMake(
      VERSUS_TYPE type,
      string comment,
      string iname,
      bool isLine = false,
      Network.ResponseCallback response = null)
    {
    }

    [Token(Token = "0x200311B")]
    public class Response
    {
      [Token(Token = "0x400EC8B")]
      [FieldOffset(Offset = "0x8")]
      public string token;
      [Token(Token = "0x400EC8C")]
      [FieldOffset(Offset = "0xC")]
      public string owner_name;
      [Token(Token = "0x400EC8D")]
      [FieldOffset(Offset = "0x10")]
      public int roomid;
      [Token(Token = "0x400EC8E")]
      [FieldOffset(Offset = "0x14")]
      public string btl_ver;

      [Token(Token = "0x600DDB0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
