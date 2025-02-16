// Wait until DOM content is fully loaded
document.addEventListener('DOMContentLoaded', () => {
    // Dropdown animation for every <details> element
    const detailsElements = document.querySelectorAll('details');
    
    detailsElements.forEach(details => {
      const list = details.querySelector('ul');
      if (!list) return;
  
      details.addEventListener('toggle', () => {
        if (details.open) {
          list.classList.remove('hidden');
          list.classList.add('animated');
          list.style.maxHeight = list.scrollHeight + 'px';
        } else {
          list.style.maxHeight = '0';
          setTimeout(() => {
            list.classList.add('hidden');
          }, 300);
        }
      });
    });

    // Highlight the current page in the dropdown
    const taskDropdown = document.getElementById('taskDropdown');
    if (taskDropdown) {
        const currentPage = window.location.pathname.split('/').pop(); // Get the current page name
        for (let option of taskDropdown.options) {
            if (option.value.includes(currentPage)) {
                option.selected = true;
                break;
            }
        }
    }

    // Dynamically load and display the large code
    const codeElement = document.getElementById("code");
    if (!codeElement) return;

    let codeLines = [];
    let currentLine = 0;
    let isUserScrolling = false;

    // Fetch the code from randomcode.js
    fetch('../../others/randomcode.js')
        .then(response => response.text())
        .then(data => {
            codeLines = data.split('\n'); // Split file into lines
            codeElement.textContent = ""; // Start empty
            codeElement.scrollTop = 0; // Start from top
            startTyping();
        })
        .catch(error => console.error("Error loading randomcode.js:", error));

    // Function to smoothly scroll to the latest line
    function scrollToCurrentLine() {
        if (!isUserScrolling) {
            codeElement.scrollTop = codeElement.scrollHeight;
        }
    }

    // Detect user scrolling
    codeElement.addEventListener('scroll', () => {
        const maxScroll = codeElement.scrollHeight - codeElement.clientHeight;
        isUserScrolling = codeElement.scrollTop < maxScroll - 10;
    });

    // Start typing effect
    function startTyping() {
        const typingInterval = setInterval(() => {
            if (currentLine < codeLines.length) {
                codeElement.textContent += codeLines[currentLine] + "\n";
                currentLine++;
                scrollToCurrentLine(); // Auto-scroll as new lines appear
            } else {
                clearInterval(typingInterval); // Stop when done
            }
        }, 50); // Adjust speed here (milliseconds per line)
    }
});
// Wait until DOM content is fully loaded
document.addEventListener('DOMContentLoaded', () => {
    // Store data in localStorage when the button is clicked
    document.getElementById('storeButton').addEventListener('click', () => {
        const inputData = document.getElementById("dataInput").value;
        if (inputData) {
            localStorage.setItem("storedData", inputData); // Save to localStorage
            displayData();
        } else {
            alert("Introduceți ceva pentru a salva!");
        }
    });

    // Display stored data when the page loads
    function displayData() {
        const storedData = localStorage.getItem("storedData");
        const displayArea = document.getElementById("dataDisplay");

        if (storedData) {
            displayArea.innerHTML = `<p><strong>Data Stocată:</strong> ${storedData}</p>`;
        } else {
            displayArea.innerHTML = "<p>Nu există date stocate.</p>";
        }
    }

    // Clear stored data when the button is clicked
    document.getElementById('clearButton').addEventListener('click', () => {
        localStorage.removeItem("storedData");
        displayData();
    });

    // Initial data display
    displayData();
});
