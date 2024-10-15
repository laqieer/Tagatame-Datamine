// Decompiled with JetBrains decompiler
// Type: SRPG.HomeUnitManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200261D")]
  [FlowNode.Pin(51, "ユニットリストを開く", FlowNode.PinTypes.Output, 51)]
  [FlowNode.Pin(12, "切り替え演出再生", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(5, "ユニットリストを開く", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(50, "ユニット選択終了", FlowNode.PinTypes.Output, 50)]
  [AddComponentMenu("UI/Home/HomeUnitManager")]
  [FlowNode.Pin(11, "ユニット選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "Refresh", FlowNode.PinTypes.Input, 10)]
  public class HomeUnitManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B180")]
    private const int PIN_IN_OPEN_UNITLIST = 5;
    [Token(Token = "0x400B181")]
    private const int PIN_IN_REFRESH = 10;
    [Token(Token = "0x400B182")]
    private const int PIN_IN_SELECT = 11;
    [Token(Token = "0x400B183")]
    private const int PIN_IN_PLAY_EFFECT = 12;
    [Token(Token = "0x400B184")]
    private const int PIN_OT_SELECTED = 50;
    [Token(Token = "0x400B185")]
    private const int PIN_OT_OPEN_UNITLIST = 51;
    [Token(Token = "0x400B186")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Header("3Dモデルとカメラの管理ROOTの移動先のGameObjectID")]
    private string HOME_UNIT_PREVIEW_ROOT;
    [Token(Token = "0x400B187")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("選択されているユニットの2D背景を表示するImage")]
    private RawImage m_BGUnitImage;
    [Token(Token = "0x400B188")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Header("選択されているユニットの3D表示空間")]
    private Transform m_UnitPreviewParent;
    [Token(Token = "0x400B189")]
    [FieldOffset(Offset = "0x18")]
    [Header("3D表示空間とカメラを管理しているRoot")]
    [SerializeField]
    private UnitPreviewForRT m_PreviewWorkObject;
    [Token(Token = "0x400B18A")]
    [FieldOffset(Offset = "0x1C")]
    [Header("ユニットのタップリアクション領域")]
    [SerializeField]
    private SRPG_Button ReactionButton;
    [Token(Token = "0x400B18B")]
    [FieldOffset(Offset = "0x20")]
    [Header("ユニット切り替え時に挟むAnimator")]
    [SerializeField]
    private Animator LoadAnimation;
    [Token(Token = "0x400B18C")]
    [FieldOffset(Offset = "0x24")]
    [Header("タップ時に再生するボイスのcueID")]
    [SerializeField]
    private string REACTION_VOICE;
    [Token(Token = "0x400B18D")]
    [FieldOffset(Offset = "0x28")]
    private UnitPreview m_HomeUnitPreview;
    [Token(Token = "0x400B18E")]
    [FieldOffset(Offset = "0x2C")]
    private MySound.Voice m_UnitVoice;
    [Token(Token = "0x400B18F")]
    [FieldOffset(Offset = "0x30")]
    private bool m_Initalized;
    [Token(Token = "0x400B190")]
    [FieldOffset(Offset = "0x31")]
    private bool m_OpenUnitList;

    [Token(Token = "0x600A9F3")]
    [Address(RVA = "0x6D3410", Offset = "0x6D2210", VA = "0x106D3410", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A9F4")]
    [Address(RVA = "0x6D36D0", Offset = "0x6D24D0", VA = "0x106D36D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A9F5")]
    [Address(RVA = "0x6D3B40", Offset = "0x6D2940", VA = "0x106D3B40")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A9F6")]
    [Address(RVA = "0x6D40E0", Offset = "0x6D2EE0", VA = "0x106D40E0")]
    private void Refresh(UnitData unit)
    {
    }

    [Token(Token = "0x600A9F7")]
    [Address(RVA = "0x6D3FB0", Offset = "0x6D2DB0", VA = "0x106D3FB0")]
    private void RefreshUnitPreview(UnitData unit)
    {
    }

    [Token(Token = "0x600A9F8")]
    [Address(RVA = "0x6D46F0", Offset = "0x6D34F0", VA = "0x106D46F0")]
    private IEnumerator WaitLoadUnitPreview() => (IEnumerator) null;

    [Token(Token = "0x600A9F9")]
    [Address(RVA = "0x6D38D0", Offset = "0x6D26D0", VA = "0x106D38D0")]
    private UnitPreview CreatePreview(UnitData unit) => (UnitPreview) null;

    [Token(Token = "0x600A9FA")]
    [Address(RVA = "0x6D3AA0", Offset = "0x6D28A0", VA = "0x106D3AA0")]
    private void DestroyPreviewObject()
    {
    }

    [Token(Token = "0x600A9FB")]
    [Address(RVA = "0x6D3F40", Offset = "0x6D2D40", VA = "0x106D3F40")]
    private IEnumerator RefreshUnitImage(UnitData unit) => (IEnumerator) null;

    [Token(Token = "0x600A9FC")]
    [Address(RVA = "0x6D3780", Offset = "0x6D2580", VA = "0x106D3780")]
    private void ChangeUnitPreview()
    {
    }

    [Token(Token = "0x600A9FD")]
    [Address(RVA = "0x6D3BA0", Offset = "0x6D29A0", VA = "0x106D3BA0")]
    private void PlayChangeUnit()
    {
    }

    [Token(Token = "0x600A9FE")]
    [Address(RVA = "0x6D3E50", Offset = "0x6D2C50", VA = "0x106D3E50")]
    private void PlayReaction()
    {
    }

    [Token(Token = "0x600A9FF")]
    [Address(RVA = "0x6D45A0", Offset = "0x6D33A0", VA = "0x106D45A0")]
    private void SetupUnitVoice(UnitData unit)
    {
    }

    [Token(Token = "0x600AA00")]
    [Address(RVA = "0x6D3CF0", Offset = "0x6D2AF0", VA = "0x106D3CF0")]
    private void PlayReactionVoice()
    {
    }

    [Token(Token = "0x600AA01")]
    [Address(RVA = "0x6D3C50", Offset = "0x6D2A50", VA = "0x106D3C50")]
    private void PlayChangeVoice()
    {
    }

    [Token(Token = "0x600AA02")]
    [Address(RVA = "0x6D3EE0", Offset = "0x6D2CE0", VA = "0x106D3EE0")]
    private void PlayUnitVoice(string name)
    {
    }

    [Token(Token = "0x600AA03")]
    [Address(RVA = "0x6D4760", Offset = "0x6D3560", VA = "0x106D4760")]
    public HomeUnitManager()
    {
    }
  }
}
