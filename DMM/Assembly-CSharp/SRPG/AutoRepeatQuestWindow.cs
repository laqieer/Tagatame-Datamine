// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002073")]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestWindow")]
  [FlowNode.Pin(100, "中断確認", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(20, "自動周回を終了", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(200, "完了済み", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  public class AutoRepeatQuestWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008BC0")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4008BC1")]
    private const int PIN_INPUT_FINISH = 20;
    [Token(Token = "0x4008BC2")]
    private const int PIN_OUTPUT_CONFIRM_SUSPEND = 100;
    [Token(Token = "0x4008BC3")]
    private const int PIN_OUTPUT_COMPLATE = 200;
    [Token(Token = "0x4008BC4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentController mContentController;

    [Token(Token = "0x60086FE")]
    [Address(RVA = "0x4840B0", Offset = "0x482EB0", VA = "0x104840B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60086FF")]
    [Address(RVA = "0x4840F0", Offset = "0x482EF0", VA = "0x104840F0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008700")]
    [Address(RVA = "0x484120", Offset = "0x482F20", VA = "0x10484120")]
    private void Init()
    {
    }

    [Token(Token = "0x6008701")]
    [Address(RVA = "0x44A4A0", Offset = "0x4492A0", VA = "0x1044A4A0")]
    private void Finish()
    {
    }

    [Token(Token = "0x6008702")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AutoRepeatQuestWindow()
    {
    }
  }
}
