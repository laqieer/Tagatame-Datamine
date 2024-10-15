// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002063")]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestInfo")]
  [FlowNode.Pin(20, "表示更新", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  public class AutoRepeatQuestInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008B32")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4008B33")]
    private const int PIN_INPUT_REFRESH = 20;
    [Token(Token = "0x4008B34")]
    private const int PIN_OUTPUT_INIT = 100;
    [Token(Token = "0x4008B35")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mBoxCountText;
    [Token(Token = "0x4008B36")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mBoxCountMaxText;
    [Token(Token = "0x4008B37")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mBoxCountMaxText2;
    [Token(Token = "0x4008B38")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mRestTimeText;
    [Token(Token = "0x4008B39")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mBoxFullOnText;
    [Token(Token = "0x4008B3A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mCurrentLapText;
    [Token(Token = "0x4008B3B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mDropItemEmpty;
    [Token(Token = "0x4008B3C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mRunningNavi;
    [Token(Token = "0x4008B3D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mFinishedNavi;
    [Token(Token = "0x4008B3E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button mBoxAddButton;

    [Token(Token = "0x600868E")]
    [Address(RVA = "0x47E850", Offset = "0x47D650", VA = "0x1047E850", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600868F")]
    [Address(RVA = "0x47E890", Offset = "0x47D690", VA = "0x1047E890")]
    private void Init()
    {
    }

    [Token(Token = "0x6008690")]
    [Address(RVA = "0x47E8B0", Offset = "0x47D6B0", VA = "0x1047E8B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008691")]
    [Address(RVA = "0x47F1B0", Offset = "0x47DFB0", VA = "0x1047F1B0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008692")]
    [Address(RVA = "0x47ECA0", Offset = "0x47DAA0", VA = "0x1047ECA0")]
    private void Update_RestTime()
    {
    }

    [Token(Token = "0x6008693")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AutoRepeatQuestInfo()
    {
    }
  }
}
