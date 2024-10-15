// Decompiled with JetBrains decompiler
// Type: SRPG.PlayBackUnitVoice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027F3")]
  [AddComponentMenu("UI/PlayBackUnitVoice")]
  public class PlayBackUnitVoice : MonoBehaviour
  {
    [Token(Token = "0x400BE23")]
    [FieldOffset(Offset = "0xC")]
    private readonly float TOOLTIP_POSITION_OFFSET_Y;
    [Token(Token = "0x400BE24")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button CloseButton;
    [Token(Token = "0x400BE25")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button Bg;
    [Token(Token = "0x400BE26")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform ItemParent;
    [Token(Token = "0x400BE27")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400BE28")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Tooltip Preafab_UnlockConditionsTooltip;
    [Token(Token = "0x400BE29")]
    [FieldOffset(Offset = "0x24")]
    private List<GameObject> mItems;
    [Token(Token = "0x400BE2A")]
    [FieldOffset(Offset = "0x28")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400BE2B")]
    [FieldOffset(Offset = "0x30")]
    private long mLastUnitUniqueID;
    [Token(Token = "0x400BE2C")]
    [FieldOffset(Offset = "0x38")]
    private PlayBackUnitVoiceItem mLastSelectItem;
    [Token(Token = "0x400BE2D")]
    [FieldOffset(Offset = "0x3C")]
    private bool mStartPlayVoice;
    [Token(Token = "0x400BE2E")]
    [FieldOffset(Offset = "0x40")]
    private UnitData.UnitPlaybackVoiceData mUnitVoiceData;
    [Token(Token = "0x400BE2F")]
    [FieldOffset(Offset = "0x44")]
    private Tooltip mUnlockConditionsTooltip;
    [Token(Token = "0x400BE30")]
    [FieldOffset(Offset = "0x48")]
    private SRPG_ScrollRect mScrollRect;
    [Token(Token = "0x400BE31")]
    [FieldOffset(Offset = "0x4C")]
    public PlayBackUnitVoice.CloseEvent OnCloseEvent;

    [Token(Token = "0x600B458")]
    [Address(RVA = "0x7AEEE0", Offset = "0x7ADCE0", VA = "0x107AEEE0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B459")]
    [Address(RVA = "0x7AFCF0", Offset = "0x7AEAF0", VA = "0x107AFCF0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B45A")]
    [Address(RVA = "0x7AF060", Offset = "0x7ADE60", VA = "0x107AF060")]
    private void OnScroll(Vector2 _vec)
    {
    }

    [Token(Token = "0x600B45B")]
    [Address(RVA = "0x7AF030", Offset = "0x7ADE30", VA = "0x107AF030")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B45C")]
    [Address(RVA = "0x7AFED0", Offset = "0x7AECD0", VA = "0x107AFED0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B45D")]
    [Address(RVA = "0x7AF050", Offset = "0x7ADE50", VA = "0x107AF050")]
    public void OnOpen()
    {
    }

    [Token(Token = "0x600B45E")]
    [Address(RVA = "0x7AF4D0", Offset = "0x7AE2D0", VA = "0x107AF4D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B45F")]
    [Address(RVA = "0x7AEF50", Offset = "0x7ADD50", VA = "0x107AEF50")]
    private void OnClose()
    {
    }

    [Token(Token = "0x600B460")]
    [Address(RVA = "0x7AF0E0", Offset = "0x7ADEE0", VA = "0x107AF0E0")]
    private void OnSelect(Button button)
    {
    }

    [Token(Token = "0x600B461")]
    [Address(RVA = "0x7AF3B0", Offset = "0x7AE1B0", VA = "0x107AF3B0")]
    private void PlayVoice(string name)
    {
    }

    [Token(Token = "0x600B462")]
    [Address(RVA = "0x7AFB40", Offset = "0x7AE940", VA = "0x107AFB40")]
    private void ShowUnlockConditionsTooltip(PlayBackUnitVoiceItem voice_item)
    {
    }

    [Token(Token = "0x600B463")]
    [Address(RVA = "0x7AFF80", Offset = "0x7AED80", VA = "0x107AFF80")]
    public PlayBackUnitVoice()
    {
    }

    [Token(Token = "0x20027F4")]
    public delegate void CloseEvent();
  }
}
