// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_Resume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200179A")]
  [FlowNode.Pin(32, "Failure", FlowNode.PinTypes.Output, 32)]
  [FlowNode.Pin(5000, "Version Mismatch", FlowNode.PinTypes.Output, 5000)]
  [FlowNode.NodeType("MultiPlay/MultiPlayResume", 32741)]
  [FlowNode.Pin(31, "Success", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(23, "Resume Multi Tower", FlowNode.PinTypes.Input, 23)]
  [FlowNode.Pin(22, "Resume Multi Versus", FlowNode.PinTypes.Input, 22)]
  [FlowNode.Pin(21, "Resume Multi Coop", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(11, "Resume Load MultiQuest", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(6000, "Is Maintenance", FlowNode.PinTypes.Output, 6000)]
  [FlowNode.Pin(7000, "Closed Room", FlowNode.PinTypes.Output, 7000)]
  [FlowNode.Pin(8000, "Can't Resume", FlowNode.PinTypes.Output, 8000)]
  [AddComponentMenu("")]
  public class FlowNode_MP_Resume : FlowNode_StartQuest
  {
    [Token(Token = "0x400550D")]
    private const int PIN_IN_RESUME_LOAD_MULTI_QUEST = 11;
    [Token(Token = "0x400550E")]
    private const int PIN_IN_RESUME_MULTI_COOP = 21;
    [Token(Token = "0x400550F")]
    private const int PIN_IN_RESUME_MULTI_VERSUS = 22;
    [Token(Token = "0x4005510")]
    private const int PIN_IN_RESUME_MULTI_TOWER = 23;
    [Token(Token = "0x4005511")]
    private const int PIN_OUT_SUCCESS = 31;
    [Token(Token = "0x4005512")]
    private const int PIN_OUT_FAILURE = 32;
    [Token(Token = "0x4005513")]
    private const int PIN_OUT_VERSION_MISMATCH = 5000;
    [Token(Token = "0x4005514")]
    private const int PIN_OUT_IS_MAINTENANCE = 6000;
    [Token(Token = "0x4005515")]
    private const int PIN_OUT_CLOSED_ROOM = 7000;
    [Token(Token = "0x4005516")]
    private const int PIN_OUT_CANNOT_RESUME = 8000;
    [Token(Token = "0x4005517")]
    [FieldOffset(Offset = "0x0")]
    public static Json_BtlInfo_Multi MultiBtlInfo;
    [Token(Token = "0x4005518")]
    [FieldOffset(Offset = "0x40")]
    private FlowNode_MP_Resume.RequestType requestType;

    [Token(Token = "0x6005FC5")]
    [Address(RVA = "0x13513E0", Offset = "0x13501E0", VA = "0x113513E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FC6")]
    [Address(RVA = "0x1351A20", Offset = "0x1350820", VA = "0x11351A20")]
    private bool RequestCoop() => new bool();

    [Token(Token = "0x6005FC7")]
    [Address(RVA = "0x1351C60", Offset = "0x1350A60", VA = "0x11351C60")]
    private bool RequestVersus() => new bool();

    [Token(Token = "0x6005FC8")]
    [Address(RVA = "0x1351B40", Offset = "0x1350940", VA = "0x11351B40")]
    private bool RequestTower() => new bool();

    [Token(Token = "0x6005FC9")]
    [Address(RVA = "0x1350FA0", Offset = "0x134FDA0", VA = "0x11350FA0")]
    private void ChangeScene()
    {
    }

    [Token(Token = "0x6005FCA")]
    [Address(RVA = "0x1351790", Offset = "0x1350590", VA = "0x11351790", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005FCB")]
    [Address(RVA = "0x1351DA0", Offset = "0x1350BA0", VA = "0x11351DA0")]
    private void ResponseCoop(string json)
    {
    }

    [Token(Token = "0x6005FCC")]
    [Address(RVA = "0x1352370", Offset = "0x1351170", VA = "0x11352370")]
    private void ResponseVersus(string json)
    {
    }

    [Token(Token = "0x6005FCD")]
    [Address(RVA = "0x1352020", Offset = "0x1350E20", VA = "0x11352020")]
    private void ResponseTower(string json)
    {
    }

    [Token(Token = "0x6005FCE")]
    [Address(RVA = "0x1351390", Offset = "0x1350190", VA = "0x11351390")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005FCF")]
    [Address(RVA = "0x1310BA0", Offset = "0x130F9A0", VA = "0x11310BA0")]
    public FlowNode_MP_Resume()
    {
    }

    [Token(Token = "0x200179B")]
    private enum RequestType
    {
      [Token(Token = "0x400551A")] Coop,
      [Token(Token = "0x400551B")] Versus,
      [Token(Token = "0x400551C")] Tower,
    }
  }
}
