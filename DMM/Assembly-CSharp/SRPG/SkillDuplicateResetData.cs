// Decompiled with JetBrains decompiler
// Type: SRPG.SkillDuplicateResetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E3E")]
  [MessagePackObject(true)]
  public class SkillDuplicateResetData
  {
    [Token(Token = "0x4007B1E")]
    [FieldOffset(Offset = "0x8")]
    public string buff;
    [Token(Token = "0x4007B1F")]
    [FieldOffset(Offset = "0xC")]
    public string skill;
    [Token(Token = "0x4007B20")]
    [FieldOffset(Offset = "0x10")]
    public int num;

    [Token(Token = "0x6007C10")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillDuplicateResetData()
    {
    }
  }
}
