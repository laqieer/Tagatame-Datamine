// Decompiled with JetBrains decompiler
// Type: UserInfoManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200024A")]
[AddComponentMenu("Manager/UserInfoManager")]
public class UserInfoManager : MonoSingleton<UserInfoManager>
{
  [Token(Token = "0x40009CA")]
  [FieldOffset(Offset = "0xC")]
  private Dictionary<string, object> info;

  [Token(Token = "0x17000172")]
  private string InfoFilePath
  {
    [Token(Token = "0x6000C2C"), Address(RVA = "0x108AFF0", Offset = "0x1089DF0", VA = "0x1108AFF0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6000C2D")]
  [Address(RVA = "0x108AC70", Offset = "0x1089A70", VA = "0x1108AC70")]
  public object GetValue(string key) => (object) null;

  [Token(Token = "0x6000C2E")]
  [Address(RVA = "0x108AF30", Offset = "0x1089D30", VA = "0x1108AF30")]
  public void SetValue(string key, object value, bool isSave = true)
  {
  }

  [Token(Token = "0x6000C2F")]
  [Address(RVA = "0x108ACF0", Offset = "0x1089AF0", VA = "0x1108ACF0")]
  private Dictionary<string, object> Load() => (Dictionary<string, object>) null;

  [Token(Token = "0x6000C30")]
  [Address(RVA = "0x108AE60", Offset = "0x1089C60", VA = "0x1108AE60")]
  private bool Save() => new bool();

  [Token(Token = "0x6000C31")]
  [Address(RVA = "0x108ABF0", Offset = "0x10899F0", VA = "0x1108ABF0")]
  public void Delete()
  {
  }

  [Token(Token = "0x6000C32")]
  [Address(RVA = "0x108AFB0", Offset = "0x1089DB0", VA = "0x1108AFB0")]
  public UserInfoManager()
  {
  }
}
