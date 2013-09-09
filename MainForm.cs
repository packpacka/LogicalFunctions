using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibraryANN;

namespace LogicalFunctions
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      //создание таблицы истинности
      //настройка параметров таблицы истинности
      dataGridSetStyleCells(dataGridViewTableLogic, 4, 4, 55, 30);
      //запись в таблицу первых двух колонок - значений для 2 логических переменных
      SetTableLogicInput(dataGridViewTableLogic, 2);
      //формирование колонки со значениями функции логическое И (2 аргумент - номер функции)
      SetLogicArgResultToTable(dataGridViewTableLogic, 1, 0, 1);
      //установка названий 3 и 4 колонок
      dataGridViewTableLogic.Columns[2].Name = "d";
      dataGridViewTableLogic.Columns[3].Name = "Y";

      //всплывающие подсказки
      //  toolTipObj.SetToolTip(this.buttonCalc, "Вычислить");

      //настройки элементов для ввода весов и порога
      int numericMin = -99;
      int numericMax = 99;
      decimal numericInc = 0.05M;
      int numericDecimalPlaces = 2;
      numericUpDownW1.Minimum = numericMin; //установка минимума
      numericUpDownW1.Maximum = numericMax; //установка максимума
      //положение запятой - 2 знака после запятой
      numericUpDownW1.DecimalPlaces = numericDecimalPlaces;
      numericUpDownW1.Increment = numericInc; //установка шага 
      numericUpDownW2.Maximum = numericMax;
      numericUpDownW2.Minimum = numericMin;
      numericUpDownW2.DecimalPlaces = numericDecimalPlaces;
      numericUpDownW2.Increment = numericInc;
      numericUpDownTeta.Maximum = numericMax;
      numericUpDownTeta.Minimum = numericMin;
      numericUpDownTeta.DecimalPlaces = numericDecimalPlaces;
      numericUpDownTeta.Increment = numericInc;

      // протокол выполнения в listbox
      _processVipolneniyaF = 1; //шаг 1 - вычисление функции И
      listBoxProtocol.Items.Add("Подберите параметры нейрона, моделирующего \"И\"");

    }

    //переменная - нейрон
    private Neuron _neur = null;
    // флаг с номером шага процесса выполнения
    private int _processVipolneniyaF = 0;


    /// <summary>
    /// Установка размеров и числа строк и ячеек элемента dataGridView
    /// </summary>
    /// <param name="dgView">Имя DataGridView </param>
    /// <param name="ColumnCount">Число колонок</param>
    /// <param name="RowCount">Число строк</param>
    /// <param name="CellSize">Размер ячеек</param>
    private void dataGridSetStyleCells(DataGridView dgView, int ColumnCount,
    int RowCount, int ColumnCellSize, int RowCellSize)
    {
      dgView.ColumnCount = ColumnCount;
      dgView.Width = ColumnCellSize * ColumnCount + 3;
      dgView.Height = RowCellSize * (RowCount + 1) + 3;
      for (int i = 0; i < ColumnCount; i++)
      {
        dgView.Columns[i].Width = ColumnCellSize;
      }
      for (int j = 0; j < RowCount; j++)
      {
        dgView.Rows.Add();
        dgView.Rows[j].Height = RowCellSize;
      }
      // запрет на изменение размера ячеек, добавление и удаление строк
      dgView.AllowUserToResizeColumns = false;
      dgView.AllowUserToDeleteRows = false;
      dgView.AllowUserToAddRows = false;
      dgView.AllowUserToResizeRows = false;
      dgView.RowHeadersVisible = false;
      dgView.ScrollBars = ScrollBars.None;
      dgView.SelectionMode = DataGridViewSelectionMode.CellSelect;
      dgView.RowTemplate.Height = RowCellSize;
    }

    /// <summary>
    /// Установка логических аргументов
    /// </summary>
    /// <param name="dgrView">Таблица</param>
    /// <param name="sizeLogicArg">Число логических аргументов</param>
    private void SetTableLogicInput(DataGridView dgrView, int sizeLogicArg)
    {
      try
      {
        // шапка таблицы
        for (int i = 0; i < sizeLogicArg; i++)
        {
          dgrView.Columns[i].Name = "X" + Convert.ToString(i + 1);
        }
        for (int i = 0; i < sizeLogicArg; i++) // столбец
        {
          int trueFlag = 0;
          // строка
          for (int j = 0; j < sizeLogicArg * sizeLogicArg; j = j + i + 1)
          {
            for (int k = j; k <= j + i; k++)
            {
              dgrView.Rows[k].Cells[sizeLogicArg - i - 1].Value = trueFlag;
            }
            trueFlag = (trueFlag == 1) ? 0 : 1;
          }
        }
      }
      catch (Exception e)
      {
        MessageBox.Show("Запись данных в несуществующую ячейку!" + e.Message);
      }
    }

    /// <summary>
    /// Установка значений логической функции
    /// </summary>
    /// <param name="dgrView">Таблица</param>
    /// <param name="logicFuncIndex">Индекс логической функции: 1 - AND;2 - OR; 3 - XOR</param>
    /// <param name="startCellInputArg">Начальн. ячейка вывода функции</param>
    /// <param name="lastCellInputArg">Последн. ячейка вывода функции</param>
    private void SetLogicArgResultToTable(DataGridView dgrView,
    int logicFuncIndex, int startCellInputArg, int lastCellInputArg)
    {
      switch (logicFuncIndex)
      {
        case 1:
          {
            for (int j = 0; j < Math.Pow(2, (lastCellInputArg - startCellInputArg + 1)); j++) // строки
            {
              Boolean output = (dgrView.Rows[j].Cells[startCellInputArg].Value.ToString() == "1") ? true : false;
              // столбцы
              for (int i = startCellInputArg + 1; i <= lastCellInputArg; i++)
              {
                Boolean currentArg = (dgrView.Rows[j].Cells[i].Value.ToString() == "1") ? true : false;
                output = (output && currentArg) ? true : false;
              }
              dgrView.Rows[j].Cells[lastCellInputArg + 1].Value = (output) ? 1 : 0;
            }
            break;
          }
        case 2:
          {

          }
      }
    }

    /// <summary>
    /// Обучение сети
    /// </summary>
    /// <param name="weight">Массив весов</param>
    /// <param name="bias">Нейронное смещение</param>
    private void TrainNet(double[] weight, double bias)
    {
      try
      {
        //Создание нового класса - пороговой активационной функции
        ThresholdFunction _func = new ThresholdFunction();
        //Создаем нейрон с 2 входами и пороговой активационной функцией
        _neur = new Neuron(2, _func);
        //Задаем веса нейрона
        _neur.Weights = weight;
        //Задаем нейронное смещение
        _neur.Bias = bias;

        //получение выходов нейронной сети
        //для каждой пары входных переменных x1 и x2
        for (int i = 0; i < dataGridViewTableLogic.Rows.Count; i++)
        {
          //Создание входного вектора нейрона
          double[] inputVector = { Convert.ToDouble
        (dataGridViewTableLogic.Rows[i].Cells[0].Value),
        Convert.ToDouble (dataGridViewTableLogic.Rows[i].Cells[1].Value)};
          //Вычисление значения сумматора
          double output = _neur.Sum(inputVector);
          //Вычисление значения активационной функции
          double Y = _neur.Activate(inputVector);
          //Запись протокола
          listBoxProtocol.Items.Add("Значение x1=" + inputVector[0].ToString());
          listBoxProtocol.Items.Add("Значение x2=" + inputVector[1].ToString());
          listBoxProtocol.Items.Add("Значение на выходе сумматора " + output.ToString());
          listBoxProtocol.Items.Add("Значение на выходе нейрона " + Y.ToString());
          //Запись значения на выходе нейрона в таблицу
          dataGridViewTableLogic.Rows[i].Cells[3].Value = Y.ToString();
        }
      }
      catch (Exception e)
      {
        MessageBox.Show("Ошибка при инициализации сети! " + e.Message);
      }
    }

    /// <summary>
    /// Окрашивание ячеек с неверным результатом и запись протокола
    /// </summary>
    private void ChangeTableResult()
    {
      Boolean trueParamWeightTetha = true;
      for (int i = 0; i < dataGridViewTableLogic.Rows.Count; i++)
      {
        if (Convert.ToString(dataGridViewTableLogic.Rows[i].Cells[2].Value) !=
    Convert.ToString(dataGridViewTableLogic.Rows[i].Cells[3].Value))
        // если значение функции найдено неверно
        {
          dataGridViewTableLogic.Rows[i].Cells[3].Style.BackColor = Color.Red;
          trueParamWeightTetha = false;
        }
        else
        {
          dataGridViewTableLogic.Rows[i].Cells[3].Style.BackColor =
    Color.White;
        }
      }

      if (!trueParamWeightTetha) // выбраны неверные параметры весов и тета
      {
        listBoxProtocol.Items.Add("Неверные параметры: (W1=" +
    numericUpDownW1.Value.ToString() + "; W2=" +
    numericUpDownW2.Value.ToString() + " ;Theta=" +
    numericUpDownTeta.Value.ToString() + ")");
      }
      else // выбраны верные параметры весов и тета
      {
        listBoxProtocol.Items.Add("Задача решена верно: (W1=" + numericUpDownW1.Value.ToString() + "; W2=" +
        numericUpDownW2.Value.ToString() + " ;Theta=" + numericUpDownTeta.Value.ToString() + ")");
      }
    }

    // Обработчик кнопки "Решить"
    private void buttonCalc_Click(object sender, EventArgs e)
    {
      double[] weight = { (double)numericUpDownW1.Value, (double)numericUpDownW2.Value }; //переменная - массив весов
      switch (_processVipolneniyaF)
      {
        case 1: // шаг 1 - функция И
          {
            // просчет заданной логической функции в сети
            // с заданными параметрами весов и порога
            // обучение сети, второй параметр смещение=-порог
            TrainNet(weight, -(double)numericUpDownTeta.Value);
            // занесение данных в таблицу, изменение параметра
            // выполненных заданий
            ChangeTableResult();
            break;
          }
      }
    }

  }
}
