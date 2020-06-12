using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Model
{
    class Actions
    {
        /// <summary>
        /// Функция добавляет в список AllFunction недостающие функции
        /// </summary>
        /// <param name="DataFunctions"></param>
        /// <param name="SelectedIndex"></param>
        public void AddFunction(FunctionViewModel DataFunctions, int SelectedIndex)
        {
            bool isHaveFunction = false;
            //Проверяем, есть ли данная функция в списке
            foreach (var all in DataFunctions?.AllFunctions)
                if (all.Name == SelectedIndex)
                    isHaveFunction = true;
            //если её нет, то добавляем
            if (!isHaveFunction)
                DataFunctions.AllFunctions.Add(new AllFunctions { Name = SelectedIndex });

        }
        /// <summary>
        /// задает "Выбранную" функцию
        /// </summary>
        /// <param name="DataFunctions"></param>
        /// <param name="SelectedIndex"></param>
        public FunctionViewModel ChooseFunction(FunctionViewModel DataFunctions, int SelectedIndex)
        {
            //Копируем данные нужной нам функции в "выбранную"
            if (DataFunctions?.SelectedFunction?.Name != SelectedIndex)
            {
                foreach (var all in DataFunctions?.AllFunctions)
                    if (all.Name == SelectedIndex)
                    {
                        DataFunctions.SelectedFunction = all; //Задаем выбранную функцию
                        //DataContext = DataFunctions;//сохраняем данные
                    }
            }
            return DataFunctions;
        }
        /// <summary>
        /// Вычисляет значения функции
        /// </summary>
        /// <param name="DataFunctions"></param>
        public FunctionViewModel CalculateResult(FunctionViewModel DataFunctions)
        {
            //Копируем данные нужной нам функции в "выбранную"
            foreach (var all in DataFunctions?.ResultFunctions)
                all.Result = all.CalculateResult(DataFunctions?.SelectedFunction);

            return DataFunctions;//сохраняем данные
        }
    }
}
