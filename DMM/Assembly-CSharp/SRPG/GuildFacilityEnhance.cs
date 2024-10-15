// Decompiled with JetBrains decompiler
// Type: SRPG.GuildFacilityEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002524")]
  [FlowNode.Pin(70, "表示更新", FlowNode.PinTypes.Input, 70)]
  [FlowNode.Pin(1010, "ゼニーで強化UI", FlowNode.PinTypes.Output, 1010)]
  [AddComponentMenu("UI/Guild/GuildFacilityEnhance")]
  [FlowNode.Pin(1000, "アイテムで強化UI", FlowNode.PinTypes.Output, 1000)]
  public class GuildFacilityEnhance : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A9C9")]
    private const int PIN_INPUT_REFRESH = 70;
    [Token(Token = "0x400A9CA")]
    private const int PIN_OUTPUT_OPEN_ENHANCE_ITEM = 1000;
    [Token(Token = "0x400A9CB")]
    private const int PIN_OUTPUT_OPEN_ENHANCE_GOLD = 1010;
    [Token(Token = "0x400A9CC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mFacilityViewItemTemplate;
    [Token(Token = "0x400A9CD")]
    [FieldOffset(Offset = "0x10")]
    private List<GameObject> mCreatedViewItems;

    [Token(Token = "0x600A34C")]
    [Address(RVA = "0x652BC0", Offset = "0x6519C0", VA = "0x10652BC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A34D")]
    [Address(RVA = "0x655970", Offset = "0x654770", VA = "0x10655970")]
    private void Start()
    {
    }

    [Token(Token = "0x600A34E")]
    [Address(RVA = "0x655970", Offset = "0x654770", VA = "0x10655970")]
    private void Init()
    {
    }

    [Token(Token = "0x600A34F")]
    [Address(RVA = "0x655B20", Offset = "0x654920", VA = "0x10655B20")]
    public void Refresh_FacilityList()
    {
    }

    [Token(Token = "0x600A350")]
    [Address(RVA = "0x6559F0", Offset = "0x6547F0", VA = "0x106559F0")]
    public void OnClick_GuildFacilityItem(GameObject item)
    {
    }

    [Token(Token = "0x600A351")]
    [Address(RVA = "0x655DE0", Offset = "0x654BE0", VA = "0x10655DE0")]
    public GuildFacilityEnhance()
    {
    }
  }
}
