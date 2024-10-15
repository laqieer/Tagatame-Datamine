// Decompiled with JetBrains decompiler
// Type: DataSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000A3")]
[AddComponentMenu("")]
public class DataSource : MonoBehaviour
{
  [Token(Token = "0x4000328")]
  [FieldOffset(Offset = "0xC")]
  private List<DataSource.DataPair> mData;

  [Token(Token = "0x60003E0")]
  [Address(RVA = "0xB84DC0", Offset = "0xB83BC0", VA = "0x10B84DC0")]
  public void Clear()
  {
  }

  [Token(Token = "0x60003E1")]
  [Address(RVA = "0xB84B50", Offset = "0xB83950", VA = "0x10B84B50")]
  public void Add(System.Type type, object data)
  {
  }

  [Token(Token = "0x60003E2")]
  public static T FindDataOfClass<T>(GameObject root, T defaultValue) => (T) null;

  [Token(Token = "0x60003E3")]
  [Address(RVA = "0xB85100", Offset = "0xB83F00", VA = "0x10B85100")]
  public static object FindDataOfClass(GameObject root, System.Type type, object defaultValue)
  {
    return (object) null;
  }

  [Token(Token = "0x60003E4")]
  public static T[] FindDataOfClassChildren<T>(GameObject root, T defaultValue) => (T[]) null;

  [Token(Token = "0x60003E5")]
  [Address(RVA = "0xB84F80", Offset = "0xB83D80", VA = "0x10B84F80")]
  public static object[] FindDataOfClassChildren(GameObject root, System.Type type, object defaultValue)
  {
    return (object[]) null;
  }

  [Token(Token = "0x60003E6")]
  public T FindDataOfClass<T>(T defaultValue) => (T) null;

  [Token(Token = "0x60003E7")]
  [Address(RVA = "0xB852B0", Offset = "0xB840B0", VA = "0x10B852B0")]
  public object FindDataOfClass(object type, object defaultValue) => (object) null;

  [Token(Token = "0x60003E8")]
  public static T FindDataOfClassAs<T>(GameObject root, T defaultValue) where T : class => (T) null;

  [Token(Token = "0x60003E9")]
  public T FindDataOfClassAs<T>(T defaultValue) where T : class => (T) null;

  [Token(Token = "0x60003EA")]
  [Address(RVA = "0xB84ED0", Offset = "0xB83CD0", VA = "0x10B84ED0")]
  public static DataSource Create(GameObject obj) => (DataSource) null;

  [Token(Token = "0x60003EB")]
  public static void Bind<T>(GameObject obj, T data, bool is_clear = false)
  {
  }

  [Token(Token = "0x60003EC")]
  [Address(RVA = "0xB84CF0", Offset = "0xB83AF0", VA = "0x10B84CF0")]
  public static void Bind(GameObject obj, System.Type type, object data, bool is_clear = false)
  {
  }

  [Token(Token = "0x60003ED")]
  [Address(RVA = "0xB84E20", Offset = "0xB83C20", VA = "0x10B84E20")]
  public static void Clear(GameObject go)
  {
  }

  [Token(Token = "0x60003EE")]
  [Address(RVA = "0xB85410", Offset = "0xB84210", VA = "0x10B85410")]
  public DataSource()
  {
  }

  [Token(Token = "0x20000A4")]
  private struct DataPair
  {
    [Token(Token = "0x4000329")]
    [FieldOffset(Offset = "0x0")]
    public System.Type Type;
    [Token(Token = "0x400032A")]
    [FieldOffset(Offset = "0x4")]
    public object Data;

    [Token(Token = "0x60003EF")]
    [Address(RVA = "0xB84B20", Offset = "0xB83920", VA = "0x10B84B20")]
    public DataPair(System.Type type, object data)
    {
    }
  }
}
