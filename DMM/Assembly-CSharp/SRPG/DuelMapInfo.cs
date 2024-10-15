// Decompiled with JetBrains decompiler
// Type: SRPG.DuelMapInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200231D")]
  [AddComponentMenu("UI/Duel/DuelMapInfo")]
  [FlowNode.Pin(10, "マップ更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "マップ期間終了", FlowNode.PinTypes.Output, 100)]
  public class DuelMapInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009CC3")]
    private const int PIN_INPUT_REFRESH_MAP = 10;
    [Token(Token = "0x4009CC4")]
    private const int PIN_OUTPUT_END_MAP = 100;
    [Token(Token = "0x4009CC5")]
    [FieldOffset(Offset = "0xC")]
    private readonly float REFRESH_INTERVAL_SEC;
    [Token(Token = "0x4009CC6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject GoMapInfoThumbnail;
    [Token(Token = "0x4009CC7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoMapInfoEndAt;
    [Token(Token = "0x4009CC8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text TextMapInfoEndAt;
    [Token(Token = "0x4009CC9")]
    [FieldOffset(Offset = "0x1C")]
    private DuelMapData mMapData;
    [Token(Token = "0x4009CCA")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsUpdateMapInfoEndAt;
    [Token(Token = "0x4009CCB")]
    [FieldOffset(Offset = "0x24")]
    private float mRestRefreshInterval;

    [Token(Token = "0x6009715")]
    [Address(RVA = "0x598EE0", Offset = "0x597CE0", VA = "0x10598EE0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009716")]
    [Address(RVA = "0x598590", Offset = "0x597390", VA = "0x10598590", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009717")]
    [Address(RVA = "0x598D10", Offset = "0x597B10", VA = "0x10598D10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009718")]
    [Address(RVA = "0x598E90", Offset = "0x597C90", VA = "0x10598E90")]
    private void UpdateMapInfoEndAt()
    {
    }

    [Token(Token = "0x6009719")]
    [Address(RVA = "0x598C10", Offset = "0x597A10", VA = "0x10598C10")]
    private bool RefreshMapInfoEndAt() => new bool();

    [Token(Token = "0x600971A")]
    [Address(RVA = "0x598720", Offset = "0x597520", VA = "0x10598720")]
    public static bool GetMapInfoViewData(
      out bool is_display,
      out string end_at_text,
      out bool is_need_refresh)
    {
      return new bool();
    }

    [Token(Token = "0x600971B")]
    [Address(RVA = "0x598FD0", Offset = "0x597DD0", VA = "0x10598FD0")]
    public DuelMapInfo()
    {
    }
  }
}
