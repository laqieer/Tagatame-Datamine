// Decompiled with JetBrains decompiler
// Type: SRPG.HighlightResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B96")]
  public class HighlightResource
  {
    [Token(Token = "0x4006937")]
    [FieldOffset(Offset = "0x8")]
    public HighlightType type;
    [Token(Token = "0x4006938")]
    [FieldOffset(Offset = "0xC")]
    public string path;
    [Token(Token = "0x4006939")]
    [FieldOffset(Offset = "0x10")]
    public string message;

    [Token(Token = "0x600720C")]
    [Address(RVA = "0x375C70", Offset = "0x374A70", VA = "0x10375C70")]
    public void Deserialize(JSON_HighlightResource json)
    {
    }

    [Token(Token = "0x600720D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public HighlightResource()
    {
    }
  }
}
