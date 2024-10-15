// Decompiled with JetBrains decompiler
// Type: SRPG.EmbedSystemMessageHyperLink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Hypertext;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002342")]
  [AddComponentMenu("UI/EmbedSystemMessageHyperLink")]
  public class EmbedSystemMessageHyperLink : MonoBehaviour
  {
    [Token(Token = "0x4009DE0")]
    private const string RegexURL = "http(s)?://([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?";
    [Token(Token = "0x4009DE1")]
    public const string PrefabPath = "e/UI/EmbedSystemMessageHyperLink";
    [Token(Token = "0x4009DE2")]
    [FieldOffset(Offset = "0xC")]
    public EmbedSystemMessageHyperLink.SystemMessageEvent Delegate;
    [Token(Token = "0x4009DE3")]
    [FieldOffset(Offset = "0x10")]
    public RegexHypertext Message;
    [Token(Token = "0x4009DE4")]
    [FieldOffset(Offset = "0x14")]
    public Button ButtonOk;

    [Token(Token = "0x60097E9")]
    [Address(RVA = "0x5A9E60", Offset = "0x5A8C60", VA = "0x105A9E60")]
    public static EmbedSystemMessageHyperLink Create(
      string msg,
      EmbedSystemMessageHyperLink.SystemMessageEvent callback,
      bool dontDestroyOnLoad = false)
    {
      return (EmbedSystemMessageHyperLink) null;
    }

    [Token(Token = "0x60097EA")]
    [Address(RVA = "0x5A9D40", Offset = "0x5A8B40", VA = "0x105A9D40")]
    private void Awake()
    {
    }

    [Token(Token = "0x17001542")]
    public string Body
    {
      [Token(Token = "0x60097EB"), Address(RVA = "0x5AA010", Offset = "0x5A8E10", VA = "0x105AA010")] set
      {
      }
      [Token(Token = "0x60097EC"), Address(RVA = "0x5A9FE0", Offset = "0x5A8DE0", VA = "0x105A9FE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60097ED")]
    [Address(RVA = "0x5A9FB0", Offset = "0x5A8DB0", VA = "0x105A9FB0")]
    private void OnOk()
    {
    }

    [Token(Token = "0x60097EE")]
    [Address(RVA = "0x5A9F90", Offset = "0x5A8D90", VA = "0x105A9F90")]
    private void OnClickURL(string url)
    {
    }

    [Token(Token = "0x60097EF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EmbedSystemMessageHyperLink()
    {
    }

    [Token(Token = "0x2002343")]
    public delegate void SystemMessageEvent(bool yes);
  }
}
