// Decompiled with JetBrains decompiler
// Type: SRPG.ObjectiveParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BFB")]
  public class ObjectiveParam
  {
    [Token(Token = "0x4006C50")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006C51")]
    [FieldOffset(Offset = "0xC")]
    public JSON_InnerObjective[] objective;

    [Token(Token = "0x600733C")]
    [Address(RVA = "0x37CFB0", Offset = "0x37BDB0", VA = "0x1037CFB0")]
    public void Deserialize(JSON_ObjectiveParam json)
    {
    }

    [Token(Token = "0x600733D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ObjectiveParam()
    {
    }
  }
}
