﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuestionManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static QuestionManager Ins; 
    public QuestionData[] questions;
    List<QuestionData> m_questions;
    QuestionData m_curQuestion;

    public QuestionData CurQuestion { get => m_curQuestion; set => m_curQuestion = value; }

    private void Awake()// kiểm tra trc khi chạy game
    {
        m_questions = questions.ToList();
        Makesingleton();
       // Debug.Log(GetRandomquestion().question);
    }  
    // tạo câu hỏi ngẫu nhiên
    public  QuestionData GetRandomquestion()
    {
        if(m_questions != null && m_questions.Count > 0)
        {
            int randIdx = Random.Range(0, m_questions.Count);
            m_curQuestion = m_questions[randIdx];
            m_questions.RemoveAt(randIdx);
        }
        return m_curQuestion;
    }
    public void Makesingleton()
    {
        if (Ins == null)
            Ins = this;
        else
            Destroy(gameObject);
    }
}
