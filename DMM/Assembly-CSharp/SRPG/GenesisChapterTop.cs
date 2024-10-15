// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisChapterTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024E8")]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/Genesis/GenesisChapterTop")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  public class GenesisChapterTop : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400A892")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x400A893")]
    public const int PIN_OUT_INIT = 101;
    [Token(Token = "0x400A894")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mBGParent;
    [Token(Token = "0x400A895")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject[] mBossButtonGO;

    [Token(Token = "0x600A208")]
    [Address(RVA = "0x63BAA0", Offset = "0x63A8A0", VA = "0x1063BAA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A209")]
    [Address(RVA = "0x63BCD0", Offset = "0x63AAD0", VA = "0x1063BCD0")]
    private bool Init() => new bool();

    [Token(Token = "0x600A20A")]
    [Address(RVA = "0x63BEC0", Offset = "0x63ACC0", VA = "0x1063BEC0")]
    private void SetupBossButton(GameObject buttonGO, QuestDifficulties difficulty)
    {
    }

    [Token(Token = "0x600A20B")]
    [Address(RVA = "0x63BAF0", Offset = "0x63A8F0", VA = "0x1063BAF0")]
    private void Downloaded(GameObject prefab)
    {
    }

    [Token(Token = "0x600A20C")]
    [Address(RVA = "0x63BBA0", Offset = "0x63A9A0", VA = "0x1063BBA0", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600A20D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisChapterTop()
    {
    }
  }
}
