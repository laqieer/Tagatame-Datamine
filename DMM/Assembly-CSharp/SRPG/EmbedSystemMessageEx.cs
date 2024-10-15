// Decompiled with JetBrains decompiler
// Type: SRPG.EmbedSystemMessageEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200233F")]
  [AddComponentMenu("UI/EmbedSystemMessageEx")]
  public class EmbedSystemMessageEx : MonoBehaviour
  {
    [Token(Token = "0x4009DD7")]
    public const string PrefabPath = "e/UI/EmbedSystemMessageEx";
    [Token(Token = "0x4009DD8")]
    [FieldOffset(Offset = "0xC")]
    public Text Message;
    [Token(Token = "0x4009DD9")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ButtonTemplate;
    [Token(Token = "0x4009DDA")]
    [FieldOffset(Offset = "0x14")]
    public GameObject CancelButtonTemplate;
    [Token(Token = "0x4009DDB")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ButtonBase;
    [Token(Token = "0x4009DDC")]
    [FieldOffset(Offset = "0x1C")]
    public string CloseEventName;

    [Token(Token = "0x60097DA")]
    [Address(RVA = "0x5A9C00", Offset = "0x5A8A00", VA = "0x105A9C00")]
    public static EmbedSystemMessageEx Create(string msg) => (EmbedSystemMessageEx) null;

    [Token(Token = "0x60097DB")]
    [Address(RVA = "0x5A9810", Offset = "0x5A8610", VA = "0x105A9810")]
    public void AddButton(
      string btn_text,
      bool is_close,
      EmbedSystemMessageEx.SystemMessageEvent callback,
      bool enableBackKey = false)
    {
    }

    [Token(Token = "0x60097DC")]
    [Address(RVA = "0x5A9840", Offset = "0x5A8640", VA = "0x105A9840")]
    public void AddCancelButton(
      string btn_text,
      bool is_close,
      EmbedSystemMessageEx.SystemMessageEvent callback,
      bool enableBackKey = false)
    {
    }

    [Token(Token = "0x60097DD")]
    [Address(RVA = "0x5A9920", Offset = "0x5A8720", VA = "0x105A9920")]
    private void CreateButton(
      GameObject template,
      GameObject parentObject,
      string btn_text,
      bool is_close,
      bool enableBackKey,
      EmbedSystemMessageEx.SystemMessageEvent callback)
    {
    }

    [Token(Token = "0x60097DE")]
    [Address(RVA = "0x5A9CB0", Offset = "0x5A8AB0", VA = "0x105A9CB0")]
    private void TriggerCloseEvent()
    {
    }

    [Token(Token = "0x60097DF")]
    [Address(RVA = "0x5A9870", Offset = "0x5A8670", VA = "0x105A9870")]
    private void Awake()
    {
    }

    [Token(Token = "0x17001541")]
    public string Body
    {
      [Token(Token = "0x60097E0"), Address(RVA = "0x5A9D10", Offset = "0x5A8B10", VA = "0x105A9D10")] set
      {
      }
      [Token(Token = "0x60097E1"), Address(RVA = "0x5A9CE0", Offset = "0x5A8AE0", VA = "0x105A9CE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60097E2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EmbedSystemMessageEx()
    {
    }

    [Token(Token = "0x2002340")]
    public delegate void SystemMessageEvent(bool yes);
  }
}
