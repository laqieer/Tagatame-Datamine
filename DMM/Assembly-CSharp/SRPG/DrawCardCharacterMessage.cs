// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardCharacterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022F5")]
  [AddComponentMenu("UI/DrawCard/DrawCardCharacterMessage")]
  public class DrawCardCharacterMessage : MonoBehaviour
  {
    [Token(Token = "0x4009BCD")]
    [FieldOffset(Offset = "0x0")]
    private static DrawCardCharacterMessage mInstance;
    [Token(Token = "0x4009BCE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mMessageParent;
    [Token(Token = "0x4009BCF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mMessageText;
    [Token(Token = "0x4009BD0")]
    private const float MESSAGE_SPEED = 0.05f;
    [Token(Token = "0x4009BD1")]
    [FieldOffset(Offset = "0x14")]
    private string mMessageString;
    [Token(Token = "0x4009BD2")]
    [FieldOffset(Offset = "0x18")]
    private int mMessageIndex;
    [Token(Token = "0x4009BD3")]
    [FieldOffset(Offset = "0x1C")]
    private float mMessageSeconds;

    [Token(Token = "0x6009642")]
    [Address(RVA = "0x58FDF0", Offset = "0x58EBF0", VA = "0x1058FDF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009643")]
    [Address(RVA = "0x5901A0", Offset = "0x58EFA0", VA = "0x105901A0")]
    private void Update()
    {
    }

    [Token(Token = "0x170014FB")]
    public static bool IsMessaging
    {
      [Token(Token = "0x6009644"), Address(RVA = "0x590420", Offset = "0x58F220", VA = "0x10590420")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009645")]
    [Address(RVA = "0x590000", Offset = "0x58EE00", VA = "0x10590000")]
    public static void ShowMessage(string message)
    {
    }

    [Token(Token = "0x6009646")]
    [Address(RVA = "0x58FF10", Offset = "0x58ED10", VA = "0x1058FF10")]
    public static void HiddenMessage()
    {
    }

    [Token(Token = "0x6009647")]
    [Address(RVA = "0x590310", Offset = "0x58F110", VA = "0x10590310")]
    private void _showMessage(string message)
    {
    }

    [Token(Token = "0x6009648")]
    [Address(RVA = "0x5902C0", Offset = "0x58F0C0", VA = "0x105902C0")]
    public DrawCardCharacterMessage()
    {
    }
  }
}
