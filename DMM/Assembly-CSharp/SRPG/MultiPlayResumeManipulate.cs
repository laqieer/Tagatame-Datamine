// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeManipulate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D9C")]
  [MessagePackObject(true)]
  public class MultiPlayResumeManipulate
  {
    [Token(Token = "0x40026D4")]
    [FieldOffset(Offset = "0x8")]
    public int value;
    [Token(Token = "0x40026D5")]
    [FieldOffset(Offset = "0xC")]
    public string skillIname;
    [Token(Token = "0x40026D6")]
    [FieldOffset(Offset = "0x10")]
    public DamageTypes damageType;
    [Token(Token = "0x40026D7")]
    [FieldOffset(Offset = "0x14")]
    public int elem;
    [Token(Token = "0x40026D8")]
    [FieldOffset(Offset = "0x18")]
    public bool passive;

    [Token(Token = "0x6003739")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayResumeManipulate()
    {
    }
  }
}
