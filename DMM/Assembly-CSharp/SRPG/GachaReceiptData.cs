// Decompiled with JetBrains decompiler
// Type: SRPG.GachaReceiptData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F1F")]
  public class GachaReceiptData
  {
    [Token(Token = "0x4002F1B")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4002F1C")]
    [FieldOffset(Offset = "0xC")]
    public string type;
    [Token(Token = "0x4002F1D")]
    [FieldOffset(Offset = "0x10")]
    public int val;

    [Token(Token = "0x6003F24")]
    [Address(RVA = "0x11777C0", Offset = "0x11765C0", VA = "0x111777C0")]
    public void Init()
    {
    }

    [Token(Token = "0x6003F25")]
    [Address(RVA = "0x1177750", Offset = "0x1176550", VA = "0x11177750")]
    public bool Deserialize(Json_GachaReceipt json) => new bool();

    [Token(Token = "0x6003F26")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GachaReceiptData()
    {
    }
  }
}
