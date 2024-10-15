// Decompiled with JetBrains decompiler
// Type: SRPG.GalleryHighlight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024C4")]
  [FlowNode.Pin(3, "Reset Text", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Base Fade out Finished", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Fade out Finished", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "Next", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Exit", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(14, "Wait First Image", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(12, "Start Fade in", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(15, "Start Fisrt Image Fade in", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(100, "Replay", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "Close Gift", FlowNode.PinTypes.Input, 101)]
  [AddComponentMenu("UI/GalleryHighlight")]
  [FlowNode.Pin(13, "Start Base Fade in", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(11, "Start Fade out", FlowNode.PinTypes.Output, 11)]
  public class GalleryHighlight : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A7C3")]
    private const int PIN_IN_NEXT = 0;
    [Token(Token = "0x400A7C4")]
    private const int PIN_IN_FADEOUT_FINISHED = 1;
    [Token(Token = "0x400A7C5")]
    private const int PIN_IN_BASE_FADEOUT_FINISHED = 2;
    [Token(Token = "0x400A7C6")]
    private const int PIN_IN_BASE_RESET_TEXT = 3;
    [Token(Token = "0x400A7C7")]
    private const int PIN_OUT_EXIT = 10;
    [Token(Token = "0x400A7C8")]
    private const int PIN_OUT_IMAGE_FADEOUT_START = 11;
    [Token(Token = "0x400A7C9")]
    private const int PIN_OUT_IMAGE_FADEIN_START = 12;
    [Token(Token = "0x400A7CA")]
    private const int PIN_OUT_BASE_FADEIN_START = 13;
    [Token(Token = "0x400A7CB")]
    private const int PIN_OUT_WAIT_FIRST_IMAGE = 14;
    [Token(Token = "0x400A7CC")]
    private const int PIN_OUT_FIRST_IMAGE_FADEIN_START = 15;
    [Token(Token = "0x400A7CD")]
    private const int PIN_IN_REPLAY = 100;
    [Token(Token = "0x400A7CE")]
    private const int PIN_IN_CLOSE_GIFT = 101;
    [Token(Token = "0x400A7CF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ScriptScreen ScriptScreen;
    [Token(Token = "0x400A7D0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject HighlightHolder;
    [Token(Token = "0x400A7D1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject HighlightBase;
    [Token(Token = "0x400A7D2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GalleryHighlightGiftWindow GiftWindow;
    [Token(Token = "0x400A7D3")]
    [FieldOffset(Offset = "0x1C")]
    [Tooltip("ユーザーがタップ操作を行なわずにメッセージの表示が完了した後、何秒後に次のページへ遷移するか。負の値を設定するとオートスキップが無効になります。")]
    [SerializeField]
    [Space(10f)]
    private float AutoSkipTime;
    [Token(Token = "0x400A7D4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Tooltip("ユーザーがタップ操作を行ってメッセージを早送りした後、何秒後に次のページへ遷移するか。負の値を設定するとオートスキップが無効になります。")]
    private float AutoSkipTimeShort;
    [Token(Token = "0x400A7D5")]
    [FieldOffset(Offset = "0x24")]
    private FlowNode_ReqGalleryHighlight.Json_Response mHighlightInfo;
    [Token(Token = "0x400A7D6")]
    [FieldOffset(Offset = "0x28")]
    private HighlightParam mHighlightParam;
    [Token(Token = "0x400A7D7")]
    [FieldOffset(Offset = "0x2C")]
    private int mCurrentIndex;
    [Token(Token = "0x400A7D8")]
    [FieldOffset(Offset = "0x30")]
    private ScriptScreen.TextParameter mHilightMessage;
    [Token(Token = "0x400A7D9")]
    [FieldOffset(Offset = "0x34")]
    private bool mAlreadyRewarded;
    [Token(Token = "0x400A7DA")]
    [FieldOffset(Offset = "0x35")]
    private bool mHilightFinished;
    [Token(Token = "0x400A7DB")]
    [FieldOffset(Offset = "0x36")]
    private bool mFadeoutFinished;
    [Token(Token = "0x400A7DC")]
    [FieldOffset(Offset = "0x37")]
    private bool mIsFirstHighLight;
    [Token(Token = "0x400A7DD")]
    [FieldOffset(Offset = "0x38")]
    private LoadRequest mLoadReq;
    [Token(Token = "0x400A7DE")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject mCurrentImage;

    [Token(Token = "0x600A143")]
    [Address(RVA = "0x6347A0", Offset = "0x6335A0", VA = "0x106347A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A144")]
    [Address(RVA = "0x634990", Offset = "0x633790", VA = "0x10634990")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A145")]
    [Address(RVA = "0x635C60", Offset = "0x634A60", VA = "0x10635C60")]
    private void Update()
    {
    }

    [Token(Token = "0x600A146")]
    [Address(RVA = "0x6358B0", Offset = "0x6346B0", VA = "0x106358B0")]
    private void ResetText()
    {
    }

    [Token(Token = "0x600A147")]
    [Address(RVA = "0x635700", Offset = "0x634500", VA = "0x10635700")]
    private void RefreshHilight(GameObject obj)
    {
    }

    [Token(Token = "0x600A148")]
    [Address(RVA = "0x634920", Offset = "0x633720", VA = "0x10634920")]
    private IEnumerator AutoSkipMessage(float waitTime) => (IEnumerator) null;

    [Token(Token = "0x600A149")]
    [Address(RVA = "0x635A00", Offset = "0x634800", VA = "0x10635A00")]
    private void ShowNextHighlight()
    {
    }

    [Token(Token = "0x600A14A")]
    [Address(RVA = "0x635850", Offset = "0x634650", VA = "0x10635850")]
    private void Replay()
    {
    }

    [Token(Token = "0x600A14B")]
    [Address(RVA = "0x634B00", Offset = "0x633900", VA = "0x10634B00")]
    private bool FindNextHighlightResource(
      FlowNode_ReqGalleryHighlight.JSON_HighlightInfo info,
      out HighlightResource resource,
      out string message,
      out object[] args)
    {
      return new bool();
    }

    [Token(Token = "0x600A14C")]
    [Address(RVA = "0x635940", Offset = "0x634740", VA = "0x10635940")]
    private void ShowGifts()
    {
    }

    [Token(Token = "0x600A14D")]
    [Address(RVA = "0x635EE0", Offset = "0x634CE0", VA = "0x10635EE0")]
    public GalleryHighlight()
    {
    }
  }
}
