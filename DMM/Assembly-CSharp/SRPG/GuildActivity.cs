// Decompiled with JetBrains decompiler
// Type: SRPG.GuildActivity
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
  [Token(Token = "0x200254B")]
  [FlowNode.Pin(10, "チャットウィンドウを開く", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/GuildActivity")]
  public class GuildActivity : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AB58")]
    private const int PIN_INPUT_OPEN_CHATWINDOW = 10;
    [Token(Token = "0x400AB59")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private float REFRESH_TIMEING;
    [Token(Token = "0x400AB5A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ChatLogItem mLogTemplate;
    [Token(Token = "0x400AB5B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x400AB5C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mMaintenancePanel;
    [Token(Token = "0x400AB5D")]
    [FieldOffset(Offset = "0x1C")]
    private readonly float FIRST_REFRESH_TIMING;
    [Token(Token = "0x400AB5E")]
    [FieldOffset(Offset = "0x20")]
    private List<ChatLogItem> mCreatedChatLogItems;
    [Token(Token = "0x400AB5F")]
    [FieldOffset(Offset = "0x24")]
    private float mRefreshTiming;
    [Token(Token = "0x400AB60")]
    [FieldOffset(Offset = "0x28")]
    private float mElapsedTime;
    [Token(Token = "0x400AB61")]
    [FieldOffset(Offset = "0x30")]
    private long mLastMessageId;
    [Token(Token = "0x400AB62")]
    [FieldOffset(Offset = "0x38")]
    private bool mIsNeedUpdateScroll;

    [Token(Token = "0x600A4AA")]
    [Address(RVA = "0x66B020", Offset = "0x669E20", VA = "0x1066B020", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A4AB")]
    [Address(RVA = "0x66B100", Offset = "0x669F00", VA = "0x1066B100")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A4AC")]
    [Address(RVA = "0x66B720", Offset = "0x66A520", VA = "0x1066B720")]
    private void Start()
    {
    }

    [Token(Token = "0x600A4AD")]
    [Address(RVA = "0x66B7D0", Offset = "0x66A5D0", VA = "0x1066B7D0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A4AE")]
    [Address(RVA = "0x66B350", Offset = "0x66A150", VA = "0x1066B350")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A4AF")]
    [Address(RVA = "0x66B110", Offset = "0x669F10", VA = "0x1066B110")]
    private void CheckUpdateScroll()
    {
    }

    [Token(Token = "0x600A4B0")]
    [Address(RVA = "0x66B290", Offset = "0x66A090", VA = "0x1066B290")]
    private void OpenChatWindow()
    {
    }

    [Token(Token = "0x600A4B1")]
    [Address(RVA = "0x66B150", Offset = "0x669F50", VA = "0x1066B150")]
    private void OnTapUnitIcon(SRPG_Button button)
    {
    }

    [Token(Token = "0x600A4B2")]
    [Address(RVA = "0x66B760", Offset = "0x66A560", VA = "0x1066B760")]
    private bool UpdateMaintenancePanel() => new bool();

    [Token(Token = "0x600A4B3")]
    [Address(RVA = "0x66B990", Offset = "0x66A790", VA = "0x1066B990")]
    public GuildActivity()
    {
    }
  }
}
