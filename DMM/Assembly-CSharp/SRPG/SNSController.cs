// Decompiled with JetBrains decompiler
// Type: SRPG.SNSController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001130")]
  [AddComponentMenu("Common/SNSController")]
  public class SNSController : MonoBehaviour
  {
    [Token(Token = "0x4003E92")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string SCREENSHOT_IMAGE_SAVE_DIR;
    [Token(Token = "0x4003E93")]
    [FieldOffset(Offset = "0x4")]
    public static readonly string SCREENSHOT_IMAGE_NAME;
    [Token(Token = "0x4003E94")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private string ShutterSECueID;
    [Token(Token = "0x4003E95")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsProcessingCapture;
    [Token(Token = "0x4003E96")]
    [FieldOffset(Offset = "0x8")]
    private static bool mIsInstalled_Twitter;
    [Token(Token = "0x4003E97")]
    [FieldOffset(Offset = "0xC")]
    private static SNSController mInstance;

    [Token(Token = "0x170007FE")]
    public bool IsProcessingCapture
    {
      [Token(Token = "0x6004977"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007FF")]
    public static bool IsInstalled_Twitter
    {
      [Token(Token = "0x6004978"), Address(RVA = "0x11F1E70", Offset = "0x11F0C70", VA = "0x111F1E70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000800")]
    public static SNSController Instance
    {
      [Token(Token = "0x6004979"), Address(RVA = "0x11F1CC0", Offset = "0x11F0AC0", VA = "0x111F1CC0")] get
      {
        return (SNSController) null;
      }
    }

    [Token(Token = "0x600497A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public static void RefreshInstalled_Twitter()
    {
    }

    [Token(Token = "0x600497B")]
    [Address(RVA = "0x11F1AA0", Offset = "0x11F08A0", VA = "0x111F1AA0")]
    public void ScreenCapture(
      string message,
      string append_img_path,
      GameObject hide_obj = null,
      bool is_test = false)
    {
    }

    [Token(Token = "0x600497C")]
    [Address(RVA = "0x11F1B40", Offset = "0x11F0940", VA = "0x111F1B40")]
    private IEnumerator _ScreenCapture(
      string message,
      string append_img_path,
      GameObject hide_obj = null,
      bool is_test = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600497D")]
    [Address(RVA = "0x11F1900", Offset = "0x11F0700", VA = "0x111F1900")]
    private IEnumerator PlayShutterEffect() => (IEnumerator) null;

    [Token(Token = "0x600497E")]
    [Address(RVA = "0x11F1520", Offset = "0x11F0320", VA = "0x111F1520")]
    private Texture2D AppendImage_RightBottom(Texture2D target, string append_img_path)
    {
      return (Texture2D) null;
    }

    [Token(Token = "0x600497F")]
    [Address(RVA = "0x11F1970", Offset = "0x11F0770", VA = "0x111F1970")]
    private Texture2D ResizeTexture(Texture2D tex, int w, int h) => (Texture2D) null;

    [Token(Token = "0x6004980")]
    [Address(RVA = "0x11F1C70", Offset = "0x11F0A70", VA = "0x111F1C70")]
    public SNSController()
    {
    }

    [Token(Token = "0x6004981")]
    [Address(RVA = "0x11F1BE0", Offset = "0x11F09E0", VA = "0x111F1BE0")]
    static SNSController()
    {
    }
  }
}
