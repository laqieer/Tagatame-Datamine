// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeProtect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D99")]
  [MessagePackObject(true)]
  public class MultiPlayResumeProtect
  {
    [Token(Token = "0x40026CD")]
    [FieldOffset(Offset = "0x8")]
    public int target;
    [Token(Token = "0x40026CE")]
    [FieldOffset(Offset = "0xC")]
    public int value;
    [Token(Token = "0x40026CF")]
    [FieldOffset(Offset = "0x10")]
    public string skillIname;

    [Token(Token = "0x6003736")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayResumeProtect()
    {
    }
  }
}
