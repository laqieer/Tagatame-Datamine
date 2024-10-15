// Decompiled with JetBrains decompiler
// Type: SRPG.LoginInfoWindow
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
  [Token(Token = "0x20026F7")]
  [FlowNode.Pin(2, "LimitedShop", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("UI/LoginInfoWindow")]
  [FlowNode.Pin(13, "Url Load End", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "Url Load", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(10, "MoiveStart", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(5, "BuyCoin", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(4, "TowerQuest", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(0, "None", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(3, "EventQuest", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(1, "Gacha", FlowNode.PinTypes.Output, 1)]
  public class LoginInfoWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B785")]
    private const int PIN_INPUT_PLAYMOVIE = 10;
    [Token(Token = "0x400B786")]
    private const int PIN_INPUT_URLJUMP = 12;
    [Token(Token = "0x400B787")]
    private const int PIN_OUTPUT_URLJUMP = 13;
    [Token(Token = "0x400B788")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button Move;
    [Token(Token = "0x400B789")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text MoveBtnText;
    [Token(Token = "0x400B78A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject Url;
    [Token(Token = "0x400B78B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Movie;
    [Token(Token = "0x400B78C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image InfoImage;
    [Token(Token = "0x400B78D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle CheckToggle;
    [Token(Token = "0x400B78E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button CloseBtn;
    [Token(Token = "0x400B78F")]
    [FieldOffset(Offset = "0x28")]
    private LoginInfoParam.SelectScene mSelectScene;
    [Token(Token = "0x400B790")]
    [FieldOffset(Offset = "0x29")]
    private bool mLoaded;
    [Token(Token = "0x400B791")]
    [FieldOffset(Offset = "0x2A")]
    private bool mRefresh;
    [Token(Token = "0x400B792")]
    [FieldOffset(Offset = "0x2C")]
    private string mUrlFileName;
    [Token(Token = "0x400B793")]
    [FieldOffset(Offset = "0x30")]
    private string mMovieFileName;
    [Token(Token = "0x400B794")]
    [FieldOffset(Offset = "0x34")]
    private bool AutoFade;
    [Token(Token = "0x400B795")]
    private const float FadeTime = 1f;
    [Token(Token = "0x400B796")]
    [FieldOffset(Offset = "0x38")]
    public Color FadeColor;

    [Token(Token = "0x600AE8F")]
    [Address(RVA = "0x72A8F0", Offset = "0x7296F0", VA = "0x1072A8F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AE90")]
    [Address(RVA = "0x72AA60", Offset = "0x729860", VA = "0x1072AA60")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AE91")]
    [Address(RVA = "0x72B570", Offset = "0x72A370", VA = "0x1072B570")]
    private void Start()
    {
    }

    [Token(Token = "0x600AE92")]
    [Address(RVA = "0x72BA30", Offset = "0x72A830", VA = "0x1072BA30")]
    private void Update()
    {
    }

    [Token(Token = "0x600AE93")]
    [Address(RVA = "0x72B240", Offset = "0x72A040", VA = "0x1072B240")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AE94")]
    [Address(RVA = "0x72AF00", Offset = "0x729D00", VA = "0x1072AF00")]
    private void OnRetry(GameObject go)
    {
    }

    [Token(Token = "0x600AE95")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnCancelRetry(GameObject go)
    {
    }

    [Token(Token = "0x600AE96")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnCancelReplay(GameObject go)
    {
    }

    [Token(Token = "0x600AE97")]
    [Address(RVA = "0x72B070", Offset = "0x729E70", VA = "0x1072B070")]
    private void PlayMovie(string fileName, bool fade = false)
    {
    }

    [Token(Token = "0x600AE98")]
    [Address(RVA = "0x72ACC0", Offset = "0x729AC0", VA = "0x1072ACC0")]
    public void OnFinished(bool is_replay = false)
    {
    }

    [Token(Token = "0x600AE99")]
    [Address(RVA = "0x72B000", Offset = "0x729E00", VA = "0x1072B000")]
    private IEnumerator PlayDelayed(string filename, StreamingMovie.OnFinished callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600AE9A")]
    [Address(RVA = "0x72ADF0", Offset = "0x729BF0", VA = "0x1072ADF0")]
    private void OnMoveScene()
    {
    }

    [Token(Token = "0x600AE9B")]
    [Address(RVA = "0x72AF20", Offset = "0x729D20", VA = "0x1072AF20")]
    private void OnValueChange(bool value)
    {
    }

    [Token(Token = "0x600AE9C")]
    [Address(RVA = "0x72AC40", Offset = "0x729A40", VA = "0x1072AC40")]
    private IEnumerator LoadImages(string path, string img) => (IEnumerator) null;

    [Token(Token = "0x600AE9D")]
    [Address(RVA = "0x72BA60", Offset = "0x72A860", VA = "0x1072BA60")]
    public LoginInfoWindow()
    {
    }

    [Token(Token = "0x20026F8")]
    public enum SelectScene : byte
    {
      [Token(Token = "0x400B798")] None,
      [Token(Token = "0x400B799")] Gacha,
      [Token(Token = "0x400B79A")] LimitedShop,
      [Token(Token = "0x400B79B")] EventQuest,
      [Token(Token = "0x400B79C")] TowerQuest,
      [Token(Token = "0x400B79D")] BuyShop,
    }
  }
}
