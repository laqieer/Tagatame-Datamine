// Decompiled with JetBrains decompiler
// Type: SRPG.AIAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C32")]
  [MessagePackObject(true)]
  public class AIAction
  {
    [Token(Token = "0x4001FF3")]
    [FieldOffset(Offset = "0x8")]
    public OString skill;
    [Token(Token = "0x4001FF4")]
    [FieldOffset(Offset = "0xC")]
    public OInt type;
    [Token(Token = "0x4001FF5")]
    [FieldOffset(Offset = "0x20")]
    public OInt turn;
    [Token(Token = "0x4001FF6")]
    [FieldOffset(Offset = "0x34")]
    public OBool notBlock;
    [Token(Token = "0x4001FF7")]
    [FieldOffset(Offset = "0x40")]
    public eAIActionNoExecAct noExecAct;
    [Token(Token = "0x4001FF8")]
    [FieldOffset(Offset = "0x44")]
    public int nextActIdx;
    [Token(Token = "0x4001FF9")]
    [FieldOffset(Offset = "0x48")]
    public eAIActionNextTurnAct nextTurnAct;
    [Token(Token = "0x4001FFA")]
    [FieldOffset(Offset = "0x4C")]
    public int turnActIdx;
    [Token(Token = "0x4001FFB")]
    [FieldOffset(Offset = "0x50")]
    public SkillLockCondition cond;

    [Token(Token = "0x600304E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AIAction()
    {
    }
  }
}
