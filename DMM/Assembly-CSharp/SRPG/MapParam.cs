// Decompiled with JetBrains decompiler
// Type: SRPG.MapParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BD8")]
  public class MapParam
  {
    [Token(Token = "0x4006AD0")]
    [FieldOffset(Offset = "0x8")]
    public string mapSceneName;
    [Token(Token = "0x4006AD1")]
    [FieldOffset(Offset = "0xC")]
    public string mapSetName;
    [Token(Token = "0x4006AD2")]
    [FieldOffset(Offset = "0x10")]
    private short battleSceneName_index;
    [Token(Token = "0x4006AD3")]
    [FieldOffset(Offset = "0x14")]
    public string eventSceneName;
    [Token(Token = "0x4006AD4")]
    [FieldOffset(Offset = "0x18")]
    private short bgmName_index;

    [Token(Token = "0x17000E40")]
    public string battleSceneName
    {
      [Token(Token = "0x60072FA"), Address(RVA = "0x37BBA0", Offset = "0x37A9A0", VA = "0x1037BBA0")] set
      {
      }
      [Token(Token = "0x60072FB"), Address(RVA = "0x37BAE0", Offset = "0x37A8E0", VA = "0x1037BAE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E41")]
    public string bgmName
    {
      [Token(Token = "0x60072FC"), Address(RVA = "0x37BC00", Offset = "0x37AA00", VA = "0x1037BC00")] set
      {
      }
      [Token(Token = "0x60072FD"), Address(RVA = "0x37BB40", Offset = "0x37A940", VA = "0x1037BB40")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60072FE")]
    [Address(RVA = "0x37B980", Offset = "0x37A780", VA = "0x1037B980")]
    public void Deserialize(JSON_MapParam json)
    {
    }

    [Token(Token = "0x60072FF")]
    [Address(RVA = "0x37BAB0", Offset = "0x37A8B0", VA = "0x1037BAB0")]
    public MapParam()
    {
    }
  }
}
