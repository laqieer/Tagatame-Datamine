// Decompiled with JetBrains decompiler
// Type: SRPG.EmbedSystemMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200233D")]
  [AddComponentMenu("UI/EmbedSystemMessage")]
  public class EmbedSystemMessage : MonoBehaviour
  {
    [Token(Token = "0x4009DD3")]
    public const string PrefabPath = "e/UI/EmbedSystemMessage";
    [Token(Token = "0x4009DD4")]
    [FieldOffset(Offset = "0xC")]
    public EmbedSystemMessage.SystemMessageEvent Delegate;
    [Token(Token = "0x4009DD5")]
    [FieldOffset(Offset = "0x10")]
    public Text Message;
    [Token(Token = "0x4009DD6")]
    [FieldOffset(Offset = "0x14")]
    public Button ButtonOk;

    [Token(Token = "0x60097D0")]
    [Address(RVA = "0x5AA130", Offset = "0x5A8F30", VA = "0x105AA130")]
    public static EmbedSystemMessage Create(
      string msg,
      EmbedSystemMessage.SystemMessageEvent callback,
      bool dontDestroyOnLoad = false)
    {
      return (EmbedSystemMessage) null;
    }

    [Token(Token = "0x60097D1")]
    [Address(RVA = "0x5AA080", Offset = "0x5A8E80", VA = "0x105AA080")]
    private void Awake()
    {
    }

    [Token(Token = "0x17001540")]
    public string Body
    {
      [Token(Token = "0x60097D2"), Address(RVA = "0x5AA210", Offset = "0x5A9010", VA = "0x105AA210")] set
      {
      }
      [Token(Token = "0x60097D3"), Address(RVA = "0x5A9FE0", Offset = "0x5A8DE0", VA = "0x105A9FE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60097D4")]
    [Address(RVA = "0x5A9FB0", Offset = "0x5A8DB0", VA = "0x105A9FB0")]
    private void OnOk()
    {
    }

    [Token(Token = "0x60097D5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EmbedSystemMessage()
    {
    }

    [Token(Token = "0x200233E")]
    public delegate void SystemMessageEvent(bool yes);
  }
}
