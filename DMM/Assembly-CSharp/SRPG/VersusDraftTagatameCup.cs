// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftTagatameCup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002742")]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftTagatameCup")]
  public class VersusDraftTagatameCup : MonoBehaviour, IWebHelp
  {
    [Token(Token = "0x400B935")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray StatusImage;
    [Token(Token = "0x400B936")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text PeriodText;
    [Token(Token = "0x400B937")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text WinCountText;
    [Token(Token = "0x400B938")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject RemainCountObj;
    [Token(Token = "0x400B939")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text RemainCountText;
    [Token(Token = "0x400B93A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button EntryButton;
    [Token(Token = "0x400B93B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject DetailButton;
    [Token(Token = "0x400B93C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject PeriodObj;
    [Token(Token = "0x400B93D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject EntryObj;
    [Token(Token = "0x400B93E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text EntryText;
    [Token(Token = "0x400B93F")]
    [FieldOffset(Offset = "0x0")]
    public static ReqVersusStatus.TagatameCupFormData mCupData;

    [Token(Token = "0x600B00C")]
    [Address(RVA = "0x744660", Offset = "0x743460", VA = "0x10744660")]
    public static void SetData(ReqVersusStatus.TagatameCupFormData _data)
    {
    }

    [Token(Token = "0x600B00D")]
    [Address(RVA = "0x743420", Offset = "0x742220", VA = "0x10743420")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B00E")]
    [Address(RVA = "0x744520", Offset = "0x743320", VA = "0x10744520", Slot = "4")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600B00F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusDraftTagatameCup()
    {
    }

    [Token(Token = "0x2002743")]
    private enum ImageType
    {
      [Token(Token = "0x400B941")] Primary,
      [Token(Token = "0x400B942")] Win,
      [Token(Token = "0x400B943")] Lose,
    }
  }
}
