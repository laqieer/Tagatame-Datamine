// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidResetBp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200182D")]
  [FlowNode.NodeType("Raid/Req/ResestBp", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidResetBp : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x40056C8")]
    public const string KEY_RAIDBOSS_HEAL_BP_ADD_NUM = "KEY_RAIDBOSS_HEAL_BP_ADD_NUM";
    [Token(Token = "0x40056C9")]
    public const string KEY_RAIDBOSS_HEAL_BP_CURRENT_NUM = "KEY_RAIDBOSS_HEAL_BP_CURRENT_NUM";

    [Token(Token = "0x6006195")]
    [Address(RVA = "0x1362670", Offset = "0x1361470", VA = "0x11362670", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006196")]
    [Address(RVA = "0x13627F0", Offset = "0x13615F0", VA = "0x113627F0", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x6006197")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidResetBp()
    {
    }
  }
}
