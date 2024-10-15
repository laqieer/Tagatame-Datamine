// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureCommonWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F79")]
  [FlowNode.Pin(101, "OKボタン表示Delay", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/Adventure/AdventureCommonWindow")]
  public class AdventureCommonWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40084EF")]
    public const string WINDOW_RESOURCE_PATH = "UI/Adventure/AdventureCommonWindow";
    [Token(Token = "0x40084F0")]
    public const string SVB_ADVENTURE_TYPE = "adventure_type";
    [Token(Token = "0x40084F1")]
    public const string SVB_ADVENTURE_ADD_AREA_NAME = "adventure_add_area_name";
    [Token(Token = "0x40084F2")]
    private const int PIN_OUTPUT_DELAY_OKBUTTON = 101;
    [Token(Token = "0x40084F3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour SVBWindow;
    [Token(Token = "0x40084F4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x40084F5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text MainText;
    [Token(Token = "0x40084F6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject DecideButtonObj;
    [Token(Token = "0x40084F7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject YesNoButtonObj;
    [Token(Token = "0x40084F8")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_AdventureCommonWindow.eAdventureWindowType mWindowType;
    [Token(Token = "0x40084F9")]
    [FieldOffset(Offset = "0x24")]
    private AdventureManager mManager;

    [Token(Token = "0x6008150")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008151")]
    [Address(RVA = "0x41DC90", Offset = "0x41CA90", VA = "0x1041DC90")]
    private void Start()
    {
    }

    [Token(Token = "0x6008152")]
    [Address(RVA = "0x41DB50", Offset = "0x41C950", VA = "0x1041DB50")]
    private void SetUpAdventureStart()
    {
    }

    [Token(Token = "0x6008153")]
    [Address(RVA = "0x41D750", Offset = "0x41C550", VA = "0x1041D750")]
    private void SetUpAdventureAddArea()
    {
    }

    [Token(Token = "0x6008154")]
    [Address(RVA = "0x41D870", Offset = "0x41C670", VA = "0x1041D870")]
    private void SetUpAdventureAddParty()
    {
    }

    [Token(Token = "0x6008155")]
    [Address(RVA = "0x41D990", Offset = "0x41C790", VA = "0x1041D990")]
    private void SetUpAdventureCancelCheck()
    {
    }

    [Token(Token = "0x6008156")]
    [Address(RVA = "0x41DA30", Offset = "0x41C830", VA = "0x1041DA30")]
    private void SetUpAdventureCancelConnectEnd()
    {
    }

    [Token(Token = "0x6008157")]
    [Address(RVA = "0x41DAC0", Offset = "0x41C8C0", VA = "0x1041DAC0")]
    private void SetUpAdventureNotStart()
    {
    }

    [Token(Token = "0x6008158")]
    [Address(RVA = "0x41D5A0", Offset = "0x41C3A0", VA = "0x1041D5A0")]
    private void SetUpAdventrueRecommendCheck()
    {
    }

    [Token(Token = "0x6008159")]
    [Address(RVA = "0x41D520", Offset = "0x41C320", VA = "0x1041D520")]
    private void SetTitleText(string _text)
    {
    }

    [Token(Token = "0x600815A")]
    [Address(RVA = "0x41D4A0", Offset = "0x41C2A0", VA = "0x1041D4A0")]
    private void SetMainText(string _text)
    {
    }

    [Token(Token = "0x600815B")]
    [Address(RVA = "0x41D430", Offset = "0x41C230", VA = "0x1041D430")]
    private void DisplayDecideButton(bool _is_decide)
    {
    }

    [Token(Token = "0x600815C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureCommonWindow()
    {
    }
  }
}
