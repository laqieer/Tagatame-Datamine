// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TutorialTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200165E")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Event/Tutorial Trigger", 58751)]
  [FlowNode.Pin(0, "Activate", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Deactivate", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "ForceExec", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Triggered", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_TutorialTrigger : FlowNode
  {
    [Token(Token = "0x400513B")]
    [FieldOffset(Offset = "0x18")]
    [BitMask]
    public FlowNode_TutorialTrigger.ActivateFlags Flags;
    [Token(Token = "0x400513C")]
    [FieldOffset(Offset = "0x1C")]
    public FlowNode_TutorialTrigger.TriggerTypes TriggerType;
    [Token(Token = "0x400513D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string sVal0;
    [Token(Token = "0x400513E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private string sVal1;
    [Token(Token = "0x400513F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int iVal0;
    [Token(Token = "0x4005140")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int iVal1;
    [Token(Token = "0x4005141")]
    [FieldOffset(Offset = "0x30")]
    public bool DontSkipFlag;

    [Token(Token = "0x6005BD8")]
    [Address(RVA = "0x1311870", Offset = "0x1310670", VA = "0x11311870")]
    private bool CompareUnit(Unit unit, int turn) => new bool();

    [Token(Token = "0x6005BD9")]
    [Address(RVA = "0x1312380", Offset = "0x1311180", VA = "0x11312380")]
    public void OnUnitStart(Unit unit, int turn)
    {
    }

    [Token(Token = "0x6005BDA")]
    [Address(RVA = "0x1312180", Offset = "0x1310F80", VA = "0x11312180")]
    public void OnUnitEnd(Unit unit, int turn)
    {
    }

    [Token(Token = "0x6005BDB")]
    [Address(RVA = "0x1312200", Offset = "0x1311000", VA = "0x11312200")]
    public void OnUnitMoveStart(Unit unit, int turn)
    {
    }

    [Token(Token = "0x6005BDC")]
    [Address(RVA = "0x1312300", Offset = "0x1311100", VA = "0x11312300")]
    public void OnUnitSkillStart(Unit unit, int turn)
    {
    }

    [Token(Token = "0x6005BDD")]
    [Address(RVA = "0x1312280", Offset = "0x1311080", VA = "0x11312280")]
    public void OnUnitSkillEnd(Unit unit, int turn)
    {
    }

    [Token(Token = "0x6005BDE")]
    [Address(RVA = "0x1312100", Offset = "0x1310F00", VA = "0x11312100")]
    public void OnTargetChange(Unit target, int turn)
    {
    }

    [Token(Token = "0x6005BDF")]
    [Address(RVA = "0x1311CE0", Offset = "0x1310AE0", VA = "0x11311CE0")]
    public void OnHotTargetsChange(Unit unit, Unit target, int turn)
    {
    }

    [Token(Token = "0x6005BE0")]
    [Address(RVA = "0x1311F40", Offset = "0x1310D40", VA = "0x11311F40")]
    public void OnSelectDirectionStart(Unit unit, int turn)
    {
    }

    [Token(Token = "0x6005BE1")]
    [Address(RVA = "0x1311EF0", Offset = "0x1310CF0", VA = "0x11311EF0")]
    public void OnMapStart()
    {
    }

    [Token(Token = "0x6005BE2")]
    [Address(RVA = "0x1311EA0", Offset = "0x1310CA0", VA = "0x11311EA0")]
    public void OnMapEnd()
    {
    }

    [Token(Token = "0x6005BE3")]
    [Address(RVA = "0x1311B40", Offset = "0x1310940", VA = "0x11311B40")]
    public void OnFinishCameraUnitFocus(Unit unit, int turn)
    {
    }

    [Token(Token = "0x6005BE4")]
    [Address(RVA = "0x1311AE0", Offset = "0x13108E0", VA = "0x11311AE0")]
    public void OnCloseBattleInfo()
    {
    }

    [Token(Token = "0x6005BE5")]
    [Address(RVA = "0x1312080", Offset = "0x1310E80", VA = "0x11312080")]
    public void OnSkipBattleExplain()
    {
    }

    [Token(Token = "0x6005BE6")]
    [Address(RVA = "0x1313FB0", Offset = "0x1312DB0", VA = "0x11313FB0")]
    private void TriggerIf(bool b)
    {
    }

    [Token(Token = "0x6005BE7")]
    [Address(RVA = "0x1314000", Offset = "0x1312E00", VA = "0x11314000")]
    private void Trigger()
    {
    }

    [Token(Token = "0x6005BE8")]
    [Address(RVA = "0x1311840", Offset = "0x1310640", VA = "0x11311840", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6005BE9")]
    [Address(RVA = "0x13119B0", Offset = "0x13107B0", VA = "0x113119B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BEA")]
    [Address(RVA = "0x13118D0", Offset = "0x13106D0", VA = "0x113118D0")]
    private void ForceExec()
    {
    }

    [Token(Token = "0x6005BEB")]
    [Address(RVA = "0x13130E0", Offset = "0x1311EE0", VA = "0x113130E0")]
    private void SetupMask_MoveUnit(
      TacticsUnitController controller,
      FlowNode_TutorialMask flownode_mask)
    {
    }

    [Token(Token = "0x6005BEC")]
    [Address(RVA = "0x1312960", Offset = "0x1311760", VA = "0x11312960")]
    private void SetupMask_AttackTargetDesc(
      TacticsUnitController controller,
      FlowNode_TutorialMask flownode_mask)
    {
    }

    [Token(Token = "0x6005BED")]
    [Address(RVA = "0x1313550", Offset = "0x1312350", VA = "0x11313550")]
    private void SetupMask_NormalAttackDesc(FlowNode_TutorialMask flownode_mask)
    {
    }

    [Token(Token = "0x6005BEE")]
    [Address(RVA = "0x1312400", Offset = "0x1311200", VA = "0x11312400")]
    private void SetupMask_AbilityDesc(FlowNode_TutorialMask flownode_mask)
    {
    }

    [Token(Token = "0x6005BEF")]
    [Address(RVA = "0x1313C80", Offset = "0x1312A80", VA = "0x11313C80")]
    private void SetupMask_TapNormalAttack(FlowNode_TutorialMask flownode_mask)
    {
    }

    [Token(Token = "0x6005BF0")]
    [Address(RVA = "0x1312DB0", Offset = "0x1311BB0", VA = "0x11312DB0")]
    private void SetupMask_ExecNormalAttack(FlowNode_TutorialMask flownode_mask)
    {
    }

    [Token(Token = "0x6005BF1")]
    [Address(RVA = "0x13138B0", Offset = "0x13126B0", VA = "0x113138B0")]
    private void SetupMask_SelectDir(
      TacticsUnitController controller,
      FlowNode_TutorialMask flownode_mask)
    {
    }

    [Token(Token = "0x6005BF2")]
    [Address(RVA = "0x1314040", Offset = "0x1312E40", VA = "0x11314040")]
    public FlowNode_TutorialTrigger()
    {
    }

    [Token(Token = "0x200165F")]
    [System.Flags]
    public enum ActivateFlags
    {
      [Token(Token = "0x4005143")] AutoActivate = 1,
      [Token(Token = "0x4005144")] AutoDeactivate = 2,
    }

    [Token(Token = "0x2001660")]
    public enum TriggerTypes
    {
      [Token(Token = "0x4005146")] None = 0,
      [Token(Token = "0x4005147")] UnitStart = 10, // 0x0000000A
      [Token(Token = "0x4005148")] UnitSkillStart = 11, // 0x0000000B
      [Token(Token = "0x4005149")] UnitMoveStart = 12, // 0x0000000C
      [Token(Token = "0x400514A")] UnitSkillEnd = 13, // 0x0000000D
      [Token(Token = "0x400514B")] UnitEnd = 14, // 0x0000000E
      [Token(Token = "0x400514C")] TargetChange = 15, // 0x0000000F
      [Token(Token = "0x400514D")] HotTargetsChange = 16, // 0x00000010
      [Token(Token = "0x400514E")] UnitSelectDirection = 17, // 0x00000011
      [Token(Token = "0x400514F")] MapStart = 18, // 0x00000012
      [Token(Token = "0x4005150")] FinishCameraUnitFocus = 19, // 0x00000013
      [Token(Token = "0x4005151")] CloseBattleInfo = 20, // 0x00000014
      [Token(Token = "0x4005152")] MapEnd = 21, // 0x00000015
      [Token(Token = "0x4005153")] SkipBattleExplain = 100, // 0x00000064
    }
  }
}
