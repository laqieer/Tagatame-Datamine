// Decompiled with JetBrains decompiler
// Type: SRPG.TwitterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B9D")]
  [AddComponentMenu("UI/TwitterMessage")]
  public class TwitterMessage : MonoBehaviour
  {
    [Token(Token = "0x400D62D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private eTwitterMessageId mId;
    [Token(Token = "0x400D62E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string mAppendImagePath;
    [Token(Token = "0x400D62F")]
    [FieldOffset(Offset = "0x14")]
    private string mConditionsKey;

    [Token(Token = "0x600C850")]
    [Address(RVA = "0x911410", Offset = "0x910210", VA = "0x10911410")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C851")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void SetConditionsKey(string key)
    {
    }

    [Token(Token = "0x600C852")]
    [Address(RVA = "0x9114E0", Offset = "0x9102E0", VA = "0x109114E0")]
    public void Post()
    {
    }

    [Token(Token = "0x600C853")]
    [Address(RVA = "0x9119B0", Offset = "0x9107B0", VA = "0x109119B0")]
    public TwitterMessage()
    {
    }
  }
}
