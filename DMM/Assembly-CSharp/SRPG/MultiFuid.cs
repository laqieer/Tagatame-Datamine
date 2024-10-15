// Decompiled with JetBrains decompiler
// Type: SRPG.MultiFuid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001049")]
  public class MultiFuid
  {
    [Token(Token = "0x4003A1D")]
    [FieldOffset(Offset = "0x8")]
    public string fuid;
    [Token(Token = "0x4003A1E")]
    [FieldOffset(Offset = "0xC")]
    public string status;

    [Token(Token = "0x60042D7")]
    [Address(RVA = "0x362350", Offset = "0x361150", VA = "0x10362350")]
    public bool Deserialize(Json_MultiFuids json) => new bool();

    [Token(Token = "0x60042D8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiFuid()
    {
    }
  }
}
