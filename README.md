# 🧠 Construction of Logical Choice

## 📘 Description

The **"Construction of Logical Choice"** project is an implementation of rational choice theory using C#. It focuses on modeling and analyzing decision-making processes under uncertainty, based on the principles of expected utility theory and subjective probabilities.

## 📚 Theoretical Background

### Rational Choice Theory

Rational choice theory states that individuals make decisions to maximize their utility, based on subjective assessments of probabilities and outcomes. Key concepts include:

* **Subjective Probabilities**: Individuals estimate the likelihood of events based on personal experience and available information.
* **Utility Function**: Each possible outcome is assigned a utility value reflecting the individual's preferences.

### Subjective Expected Utility (SEU)

The Subjective Expected Utility model, introduced by Leonard Savage, formalizes decision-making under uncertainty. It involves:

* **Subjective Probability**: Personal assessment of the probability of an event occurring.
* **Utility Function**: Evaluation of the utility of each possible outcome.
* **Expected Utility**: Sum of the products of probability and utility for all possible outcomes.

### Applications in Artificial Intelligence

In AI and decision theory, logical choice theory is used to develop agents capable of making optimal decisions in complex and uncertain environments.

## ⚙️ Project Structure

* **Core Algorithm**: Implements the decision-making model based on subjective expected utility.
* **Probability Module**: Allows setting and updating subjective probabilities of events.
* **Utility Module**: Evaluates the utility of different outcomes for an individual.
* **User Interface**: Provides tools for interacting with the model and visualizing results.

## 🚀 Installation & Usage

### Installation

1. Clone the repository:

```bash
git clone https://github.com/MykytaOleksandrovychVakarenko/Construction_of_logical_choice.git
```

2. Open the solution in Visual Studio:

```bash
Construction_of_logical_choice.sln
```

3. Build and run the project.

### Example Usage

```csharp
using LogicalChoice;

var agent = new DecisionAgent();
agent.SetSubjectiveProbability("Rain", 0.3);
agent.SetUtility("GoOutside", 10);
agent.SetUtility("StayHome", 5);

var decision = agent.MakeDecision();
Console.WriteLine($"Recommended action: {decision}");
```

### Expected Output

```
Recommended action: GoOutside
```

## 🧪 Examples & Tests

The `Tests` folder contains unit tests validating the core components of the system:

* **DecisionAgentTests.cs**: Tests decision-making logic.
* **ProbabilityEvaluatorTests.cs**: Checks probability evaluation.
* **UtilityEvaluatorTests.cs**: Tests utility assessment.

## 🔧 Future Development

Potential directions for further development:

* **Integration with external data sources**: Use real-world data to assess probabilities and utilities.
* **Model expansion**: Include additional factors such as social influence or resource constraints.
* **Performance optimization**: Improve algorithms to handle larger datasets efficiently.

## 📄 License

This project is licensed under the MIT License. See the LICENSE file for details.
