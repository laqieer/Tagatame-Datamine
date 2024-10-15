// Decompiled with JetBrains decompiler
// Type: SRPG.ChatChannelItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002153")]
  [AddComponentMenu("UI/ChatChannelItem")]
  public class ChatChannelItem : MonoBehaviour
  {
    [Token(Token = "0x4009136")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Begginer;
    [Token(Token = "0x4009137")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ChannelName;
    [Token(Token = "0x4009138")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject Fever;
    [Token(Token = "0x4009139")]
    [FieldOffset(Offset = "0x18")]
    private int mChannelID;

    [Token(Token = "0x170013C1")]
    public int ChannelID
    {
      [Token(Token = "0x6008BF1"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008BF2")]
    [Address(RVA = "0x4FABE0", Offset = "0x4F99E0", VA = "0x104FABE0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008BF3")]
    [Address(RVA = "0x4FACD0", Offset = "0x4F9AD0", VA = "0x104FACD0")]
    public void Refresh(ChatChannelParam param)
    {
    }

    [Token(Token = "0x6008BF4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChatChannelItem()
    {
    }
  }
}
