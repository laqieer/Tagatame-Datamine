// Decompiled with JetBrains decompiler
// Type: SRPG.ChangeListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002137")]
  public class ChangeListData
  {
    [Token(Token = "0x400909A")]
    [FieldOffset(Offset = "0x8")]
    public int ItemID;
    [Token(Token = "0x400909B")]
    [FieldOffset(Offset = "0xC")]
    public System.Type MetaDataType;
    [Token(Token = "0x400909C")]
    [FieldOffset(Offset = "0x10")]
    public object MetaData;
    [Token(Token = "0x400909D")]
    [FieldOffset(Offset = "0x14")]
    public string Label;
    [Token(Token = "0x400909E")]
    [FieldOffset(Offset = "0x18")]
    public string ValOld;
    [Token(Token = "0x400909F")]
    [FieldOffset(Offset = "0x1C")]
    public string ValNew;

    [Token(Token = "0x6008B6A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChangeListData()
    {
    }
  }
}
