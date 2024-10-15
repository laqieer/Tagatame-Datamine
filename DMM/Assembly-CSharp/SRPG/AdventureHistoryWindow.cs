// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureHistoryWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F9A")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Adventure/AdventureHistoryWindow")]
  public class AdventureHistoryWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400858C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400858D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoParentItem;
    [Token(Token = "0x400858E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private AdventureHistoryItem TemplateItem;
    [Token(Token = "0x400858F")]
    private const int PIN_IN_INIT = 1;

    [Token(Token = "0x60081D8")]
    [Address(RVA = "0x422CC0", Offset = "0x421AC0", VA = "0x10422CC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60081D9")]
    [Address(RVA = "0x422FE0", Offset = "0x421DE0", VA = "0x10422FE0")]
    private void Init()
    {
    }

    [Token(Token = "0x60081DA")]
    [Address(RVA = "0x422D30", Offset = "0x421B30", VA = "0x10422D30")]
    private void CreateHistory(AdventureManager am)
    {
    }

    [Token(Token = "0x60081DB")]
    [Address(RVA = "0x422BD0", Offset = "0x4219D0", VA = "0x10422BD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60081DC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureHistoryWindow()
    {
    }
  }
}
